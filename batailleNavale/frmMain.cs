using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using SimpleTCP;

namespace batailleNavale
{
    public partial class frmMain : Form
    {
        SimpleTcpServer server;
        SimpleTcpClient client;

        Random rndButtonToShoot = new Random();

        string tempTag = "";
        string receivedTag = "";
        string notification = "";
        string listElements = "";
        int opponentScore = 0;

        int score = 0;
        bool myTurn = false;
        bool opponentReady = false;
        bool gameEnded = false;
        bool closingMessageShown = false;
        bool tmrAutoShootEnable = false;
        int boatTag = 0;
        int cmptBtn = 0;
        int cmptBtnToShoot = 0;
        int cmptTimeToShoot = 60;
        string boatText = "";
        const int ROW_COUNT = 10;
        const int COLUMN_COUNT = 10;
        bool isVertical = false;
        int lineBreak = COLUMN_COUNT;

        // listes des positions des bateaux -> sera vidée au fur et à mesure des tirs
        List<string> listPorteAvion = new List<string>();
        List<string> listCroiseur = new List<string>();
        List<string> listContreTorpilleur = new List<string>();
        List<string> listSousMarin = new List<string>();
        List<string> listTorpilleur = new List<string>();

        // listes des positions des bateaux -> ne sera pas vidée au fur et à mesure des tirs
        List<string> listpositionPorteAvionToSink = new List<string>();
        List<string> listpositionCroiseurToSink = new List<string>();
        List<string> listpositionContreTorpilleurToSink = new List<string>();
        List<string> listpositionSousMarinToSink = new List<string>();
        List<string> listpositionTorpilleurToSink = new List<string>();

        List<Button> listOfAvailableButton = new List<Button>();


        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Au chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batailleNavale_Load(object sender, EventArgs e)

        {
            server = frmConnexion.SERVER;
            client = frmConnexion.CLIENT;

            server.DataReceived += Server_DataReceived;
            initializeAllGrids();

        }

        /// <summary>
        /// Retourne l'adresse ip de la machine
        /// </summary>
        /// <returns> l'adresse ip de la machine </returns>
        private string listToString(List<string> list)
        {
            foreach (var element in list)
            {
                if (list.Last() != element)
                    listElements += element + ",";
                else
                    listElements += element;

            }
            return listElements;
        }

        /// <summary>
        /// Quand des données sont reçues, le serveur regarde l'entête (3 premiers caractères réservés) et agi et fonction. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {

            string dataType = e.MessageString.Substring(0, 3);
            string dataWOType = e.MessageString.Substring(3, e.MessageString.Length - 4);

            if (dataType == "msg")
            {
                frmConnexion.TBX_IP_CLIENT.Invoke((MethodInvoker)delegate ()
               {
                   lsbMessages.Items.Add(String.Format("Adversaire :{0}", Environment.NewLine + dataWOType + Environment.NewLine));
               });
            }
            else
            {
                switch (dataType)
                {
                    case "sht":
                        receivedTag = dataWOType;

                        break;
                    case "not":
                        notification = dataWOType;
                        if (dataWOType == "Prêt")
                        {
                            opponentReady = true;
                        }
                        break;
                    case "elm":
                        listElements = dataWOType;
                        break;
                    case "trn":
                        if (!gameEnded)
                        {
                            myTurn = true;
                            tmrAutoShootEnable = true;
                            lblMessages.Invoke((MethodInvoker)delegate ()
                            {
                                lblMessages.Text = "À VOTRE TOUR !";
                            });
                        }
                        else
                        {
                            myTurn = false;
                        }

                        break;
                    default:
                        break;
                }
                Shoot();
            }

        }

        /// <summary>
        /// Envoie le message avec l'entête msg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            client.WriteLine("msg" + tbxMessage.Text);
            lsbMessages.Items.Add(String.Format("Moi :{0}", Environment.NewLine + tbxMessage.Text + Environment.NewLine));
            tbxMessage.Clear();
        }

        /// <summary>
        /// Méthode permettant d'initialiser la grille de l'adversaire et la grille personnelle
        /// </summary>
        void initializeAllGrids()
        {
            pnlRight.AllowDrop = true;
            tlpPersonalGrid.AllowDrop = true;

            this.tlpOpponentGrid.ColumnCount = COLUMN_COUNT;
            this.tlpOpponentGrid.RowCount = ROW_COUNT;

            this.tlpOpponentGrid.ColumnStyles.Clear();
            this.tlpOpponentGrid.RowStyles.Clear();

            this.tlpPersonalGrid.ColumnCount = COLUMN_COUNT;
            this.tlpPersonalGrid.RowCount = ROW_COUNT;

            this.tlpPersonalGrid.ColumnStyles.Clear();
            this.tlpPersonalGrid.RowStyles.Clear();

            this.tlpLettersOpponent.RowCount = ROW_COUNT;
            this.tlpLettersOpponent.RowStyles.Clear();

            this.tlpLettersPersonal.RowCount = ROW_COUNT;
            this.tlpLettersPersonal.RowStyles.Clear();

            this.tlpNumbersOpponent.ColumnCount = COLUMN_COUNT;
            this.tlpNumbersOpponent.ColumnStyles.Clear();

            this.tlpNumbersPersonal.ColumnCount = COLUMN_COUNT;
            this.tlpNumbersPersonal.ColumnStyles.Clear();


            for (int i = 0; i < COLUMN_COUNT + 1; i++)
            {
                this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / COLUMN_COUNT));
            }
            for (int i = 0; i < ROW_COUNT + 1; i++)
            {
                this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / ROW_COUNT));
            }

            // Initialisation des boutons de la grille adverse
            for (int i = 0; i < COLUMN_COUNT; i++)
            {
                for (int j = 0; j < ROW_COUNT; j++)
                {
                    var btn = new Button();
                    btn.Name = string.Format("btn{0}", cmptBtn);
                    btn.Tag = string.Format(((char)(65 + i)).ToString() + (j + 1).ToString());
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Button.DefaultBackColor;
                    btn.Click += btn_Click;
                    listOfAvailableButton.Add(btn);
                    this.tlpOpponentGrid.Controls.Add(btn);
                }
            }

            for (int i = 0; i < COLUMN_COUNT; i++)
            {
                this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / COLUMN_COUNT));
            }
            for (int i = 0; i < ROW_COUNT; i++)
            {
                this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / ROW_COUNT));
            }

            // Initialisation des boutons de la grille personnelle
            for (int i = 0; i < COLUMN_COUNT; i++)
            {
                for (int j = 0; j < ROW_COUNT; j++)
                {
                    var btn = new Button();
                    btn.Name = string.Format("btn{0}", cmptBtn);
                    btn.Tag = string.Format(((char)(65 + i)).ToString() + (j + 1).ToString());
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Button.DefaultBackColor;
                    btn.AllowDrop = true;
                    btn.DragDrop += btnDrop;
                    btn.DragEnter += btnToDrag_DragEnter;
                    btn.DragOver += btnDragOver;
                    this.tlpPersonalGrid.Controls.Add(btn);
                    cmptBtn++;
                }
            }

            for (int i = 0; i < ROW_COUNT; i++)
            {
                this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / ROW_COUNT));
                this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / ROW_COUNT));
            }

            for (int i = 0; i < COLUMN_COUNT; i++)
            {
                this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / COLUMN_COUNT));
                this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / COLUMN_COUNT));
            }

            for (int i = 0; i < ROW_COUNT; i++)
            {
                var lbl = new Label();
                lbl.Name = string.Format("lblOpponentLetters{0}", (char)(i + 65));
                lbl.Text = ((char)(i + 65)).ToString();
                lbl.Font = lblScore.Font;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                this.tlpLettersOpponent.Controls.Add(lbl);
                lbl = new Label();
                lbl.Name = string.Format("lblPersonalLetters{0}", (char)(i + 65));
                lbl.Text = ((char)(i + 65)).ToString();
                lbl.Font = lblScore.Font;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                this.tlpLettersPersonal.Controls.Add(lbl);
            }

            for (int i = 0; i < COLUMN_COUNT; i++)
            {
                var lbl = new Label();
                lbl.Name = string.Format("lblOpponentNumbers{0}", i + 1);
                lbl.Text = (i + 1).ToString();
                lbl.Font = lblScore.Font;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                this.tlpNumbersOpponent.Controls.Add(lbl);
                lbl = new Label();
                lbl.Name = string.Format("lblPersonalNumbers", (char)(i + 65));
                lbl.Text = (i + 1).ToString();
                lbl.Font = lblScore.Font;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                this.tlpNumbersPersonal.Controls.Add(lbl);
            }
            cmptBtn = 0;
        }


        /// <summary>
        /// Quand le joueur clique sur un bouton de la grille de gauche (tir)
        /// </summary>
        /// <param name="sender"> bouton cliqué par le joueur </param>
        /// <param name="e"> évènements du bouton </param>
        private void btn_Click(object sender, EventArgs e)
        {
            if (myTurn)
            {
                Button btn = sender as Button;
                client.WriteLine("sht" + btn.Tag.ToString());
                tempTag = btn.Tag.ToString();
            }
            if (myTurn)
            {
                myTurn = false;
                client.WriteLine("trn" + "true");
                lblMessages.Text = "AU TOUR DE L'ADVERSAIRE!";
            }
        }

        /// <summary>
        /// Effectue les actions liées au tir
        /// </summary>
        private void Shoot()
        {
            string tag = receivedTag;
            tlpOpponentGrid.Invoke((MethodInvoker)delegate ()
            {
                tlpOpponentGrid.Enabled = true;
            });
            if (tag != "")
            {
                if (listPorteAvion.Contains(tag) || listCroiseur.Contains(tag) || listContreTorpilleur.Contains(tag) || listSousMarin.Contains(tag) || listTorpilleur.Contains(tag))
                {

                    client.WriteLine("not" + "TOUCHÉ !");
                    opponentScore++;

                    foreach (Button button in tlpPersonalGrid.Controls.OfType<Button>())
                    {
                        if (button.Tag.ToString() == tag)
                        {
                            tlpPersonalGrid.Invoke((MethodInvoker)delegate ()
                            {
                                tlpPersonalGrid.Enabled = true;
                            });

                            button.Invoke((MethodInvoker)delegate ()
                            {
                                button.BackColor = Color.Red;
                            });

                            tlpPersonalGrid.Invoke((MethodInvoker)delegate ()
                            {
                                tlpPersonalGrid.Enabled = false;
                            });
                        }
                    }
                    if (listPorteAvion.Contains(tag))
                        listPorteAvion.Remove(tag);
                    if (listCroiseur.Contains(tag))
                        listCroiseur.Remove(tag);
                    if (listContreTorpilleur.Contains(tag))
                        listContreTorpilleur.Remove(tag);
                    if (listSousMarin.Contains(tag))
                        listSousMarin.Remove(tag);
                    if (listTorpilleur.Contains(tag))
                        listTorpilleur.Remove(tag);
                }
                else
                {
                    client.WriteLine("not" + "DANS L'EAU !");


                    foreach (Button button in tlpPersonalGrid.Controls.OfType<Button>())
                    {
                        if (button.Tag.ToString() == tag)
                        {
                            tlpPersonalGrid.Invoke((MethodInvoker)delegate ()
                            {
                                tlpPersonalGrid.Enabled = true;
                            });
                            button.Invoke((MethodInvoker)delegate ()
                            {
                                button.BackColor = Color.Gray;
                            });
                            tlpPersonalGrid.Invoke((MethodInvoker)delegate ()
                            {
                                tlpPersonalGrid.Enabled = false;
                            });
                        }
                    }
                }

                if (listPorteAvion.Count == 0)
                {
                    DisplaySunk(listpositionPorteAvionToSink);
                    listPorteAvion.Add("tc");
                    client.WriteLine("elm" + listToString(listpositionPorteAvionToSink));
                    opponentScore += 5;
                    VerifiyVictory();
                }
                if (listCroiseur.Count == 0)
                {
                    DisplaySunk(listpositionCroiseurToSink);
                    listCroiseur.Add("tc");
                    client.WriteLine("elm" + listToString(listpositionCroiseurToSink));
                    opponentScore += 5;
                    VerifiyVictory();
                }
                if (listContreTorpilleur.Count == 0)
                {
                    DisplaySunk(listpositionContreTorpilleurToSink);
                    listContreTorpilleur.Add("tc");
                    client.WriteLine("elm" + listToString(listpositionContreTorpilleurToSink));
                    opponentScore += 5;
                    VerifiyVictory();
                }
                if (listSousMarin.Count == 0)
                {
                    DisplaySunk(listpositionSousMarinToSink);
                    listSousMarin.Add("tc");
                    client.WriteLine("elm" + listToString(listpositionSousMarinToSink));
                    opponentScore += 5;
                    VerifiyVictory();
                }
                if (listTorpilleur.Count == 0)
                {
                    DisplaySunk(listpositionTorpilleurToSink);
                    listTorpilleur.Add("tc");
                    client.WriteLine("elm" + listToString(listpositionTorpilleurToSink));
                    opponentScore += 5;
                    VerifiyVictory();
                }

                Thread.Sleep(10);
                listElements = "";
            }
            if (notification == "TOUCHÉ !")
            {
                foreach (Button button in tlpOpponentGrid.Controls.OfType<Button>())
                {
                    if (button.Tag.ToString() == tempTag)
                    {
                        button.Invoke((MethodInvoker)delegate ()
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        });
                    }
                }
                score++;
            }
            if (notification == "DANS L'EAU !")
            {
                foreach (Button button in tlpOpponentGrid.Controls.OfType<Button>())
                {
                    if (button.Tag.ToString() == tempTag)
                    {
                        button.Invoke((MethodInvoker)delegate ()
                        {
                            button.BackColor = Color.Gray;
                            button.Enabled = false;
                        });
                    }
                }
            }

            if (listElements != "")
            {
                score += 5;
                List<string> tagList = listElements.Split(',').ToList();
                foreach (Button button in tlpOpponentGrid.Controls.OfType<Button>())
                {
                    if (tagList.Contains(button.Tag.ToString()))
                    {
                        button.Invoke((MethodInvoker)delegate ()
                        {
                            button.Text = "X";
                        });
                    }
                }
            }

            if (notification == "VICTOIRE !")
            {
                lblMessages.Invoke((MethodInvoker)delegate ()
               {
                   lblMessages.Text = "VICTOIRE !" + Environment.NewLine + "Pour recommencer, cliquez sur Nouvelle Partie ou cliquez sur Quitter pour quitter";
               });
                tlpOpponentGrid.Invoke((MethodInvoker)delegate ()
                {
                    tlpOpponentGrid.Enabled = false;
                });
                btnReadyAndNewGame.Invoke((MethodInvoker)delegate ()
                {
                    btnReadyAndNewGame.Enabled = true;
                });
                myTurn = true;
                gameEnded = true;
            }
            receivedTag = "";
            notification = "";
            listElements = "";
            tempTag = "";
            cmptTimeToShoot = 60;
        }

        /// <summary>
        /// Vérifie si tous les bateaux ont été touché coulés et envoie la notification de victoire si c'est le cas.
        /// </summary>
        /// <returns></returns>
        private void VerifiyVictory()
        {
            if (listPorteAvion.Contains("tc") && listCroiseur.Contains("tc") && listContreTorpilleur.Contains("tc") && listSousMarin.Contains("tc") && listTorpilleur.Contains("tc"))
            {
                client.WriteLine("not" + "VICTOIRE !");
                lblMessages.Invoke((MethodInvoker)delegate ()
                {
                    lblMessages.Text = "DÉFAITE !" + Environment.NewLine + "Pour recommencer, cliquez sur Nouvelle Partie ou cliquez sur Quitter pour quitter";
                });

                tlpOpponentGrid.Invoke((MethodInvoker)delegate ()
                {
                    tlpOpponentGrid.Enabled = false;
                });

                btnReadyAndNewGame.Invoke((MethodInvoker)delegate ()
                {
                    btnReadyAndNewGame.Enabled = true;
                });
                gameEnded = true;
            }
        }

        /// <summary>
        /// Affiche une croix dans les boutons représentant les bateaux lorsque ceux-ci ont été coulés. 
        /// </summary>
        /// <param name="listPositionBoat"> liste des bateaux coulés</param>
        private void DisplaySunk(List<string> listPositionBoat)
        {
            foreach (Button button in tlpPersonalGrid.Controls.OfType<Button>())
            {
                if (listPositionBoat.Contains(button.Tag.ToString()))
                {
                    button.Invoke((MethodInvoker)delegate ()
                    {
                        button.Text = "X";
                    });
                }
            }

        }

        /// <summary>
        /// Quand un composant est glissé au dessus et dans les limites des boutons de la grille de droite, le composant peut bouger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">évènement de glisser</param>
        private void btnToDrag_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Lorsqu'un bouton représentant un bateau est déposé sur un bouton de la grille de droite, la couleur de fond des boutons qui recoivent le bateau deviennent noir.
        /// Les listes de bateaux sont initialisées ici.
        /// </summary>
        /// <param name="sender"> le bouton de la grille de droite qui reçois le bouton représentant le bateau (parent du bouton bateau)</param>
        /// <param name="e">évènements liés au glisser-déposé</param>
        private void btnDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Button)sender;
            string boatsNames = ((Button)e.Data.GetData(typeof(Button))).Name;
            Button btn = (Button)sender;
            Control btnNext = tlpPersonalGrid.Controls[0];
            int btnIndex = Convert.ToInt32(btn.Name.Substring(3));
            int indexOfBtn = tlpPersonalGrid.Controls.GetChildIndex(btn);


            for (int i = 0; i < boatTag; i++)
            {
                if (!isVertical)
                {
                    btnNext = tlpPersonalGrid.Controls[btnIndex + i];
                }
                else
                {
                    btnNext = tlpPersonalGrid.Controls[btnIndex + lineBreak * i];
                }
                btnNext.BackColor = Color.Black;

                switch (boatsNames)
                {
                    case "btnPorteAvion":
                        listPorteAvion.Add(btnNext.Tag.ToString());
                        listpositionPorteAvionToSink.Add(btnNext.Tag.ToString());
                        break;
                    case "btnCroiseur":
                        listCroiseur.Add(btnNext.Tag.ToString());
                        listpositionCroiseurToSink.Add(btnNext.Tag.ToString());

                        break;
                    case "btnContreTorpilleur":
                        listContreTorpilleur.Add(btnNext.Tag.ToString());
                        listpositionContreTorpilleurToSink.Add(btnNext.Tag.ToString());

                        break;
                    case "btnSousMarin":
                        listSousMarin.Add(btnNext.Tag.ToString());
                        listpositionSousMarinToSink.Add(btnNext.Tag.ToString());

                        break;
                    case "btnTorpilleur":
                        listTorpilleur.Add(btnNext.Tag.ToString());
                        listpositionTorpilleurToSink.Add(btnNext.Tag.ToString());

                        break;
                    default:
                        break;
                }

            }
        }

        /// <summary>
        /// lorsqu'un bouton représentant un bateau est cliqué et maintenu, il peut être déplacé et est masqué
        /// </summary>
        /// <param name="sender"> le bouton cliqué représentant un bateau </param>
        /// <param name="e"></param>
        private void btnPorteAvion_MouseDown(object sender, MouseEventArgs e)
        {
            Button boatBtn = (Button)sender;
            boatText = boatBtn.Text;
            boatTag = Convert.ToInt32(boatBtn.Tag);
            boatBtn.DoDragDrop(boatBtn, DragDropEffects.Move);
            boatBtn.Hide();

            if (listPorteAvion.Count != 0 && listCroiseur.Count != 0 && listContreTorpilleur.Count != 0 && listSousMarin.Count != 0 && listTorpilleur.Count != 0)
            {
                btnReadyAndNewGame.Enabled = true;
            }
        }

        /// <summary>
        /// Quand un composant est glissé au dessus des limites des boutons de la grille de droite, la couleur de fond des boutons qui vont recevoir le bateau deviennent jaunes.
        /// </summary>
        /// <param name="sender"> le bouton de la grille de droite qui reçois le bouton représentant le bateau</param>
        /// <param name="e">évènements liés au glisser-déposé</param>
        private void btnDragOver(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Button)sender;
            Button btn = (Button)sender;
            for (int i = 0; i < tlpPersonalGrid.Controls.Count; i++)
            {
                if (tlpPersonalGrid.Controls[i].BackColor == Color.Yellow)
                    tlpPersonalGrid.Controls[i].BackColor = Button.DefaultBackColor;
                tlpPersonalGrid.Controls[i].AllowDrop = true;
            }
            int btnIndex = Convert.ToInt32(btn.Name.Substring(3));
            int btnNbColumn = Convert.ToInt32(btn.Tag.ToString().Substring(1));
            int btnNbRow = (Convert.ToChar(btn.Tag.ToString().Substring(0, 1))) - 64;
            int cmptDisponibleSpace = 0;

            if (!isVertical)
            {
                if (btnNbColumn <= (COLUMN_COUNT - (boatTag - 1)))
                {
                    for (int i = 0; i < boatTag; i++)
                    {
                        Control btnNext = tlpPersonalGrid.Controls[btnIndex + i];
                        for (int j = 0; j < boatTag; j++)
                        {
                            Control btnNextTemp = tlpPersonalGrid.Controls[btnIndex + j];
                            if (btnNextTemp.BackColor == Color.Black)
                            {
                                cmptDisponibleSpace++;
                            }
                        }
                        if (cmptDisponibleSpace == 0)
                        {
                            btnNext.AllowDrop = true;
                            btnNext.BackColor = Color.Yellow;
                        }
                        else
                        {
                            btnNext.AllowDrop = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < boatTag; i++)
                    {
                        if (tlpPersonalGrid.Controls.Count - btnIndex >= boatTag)
                        {
                            Control btnNext = tlpPersonalGrid.Controls[btnIndex + i];
                            btnNext.AllowDrop = false;
                        }
                        else
                        {
                            Control btnNext = tlpPersonalGrid.Controls[tlpPersonalGrid.Controls.Count - i - 1];
                            btnNext.AllowDrop = false;
                        }
                    }
                }
            }
            else
            {
                if (btnNbRow <= (ROW_COUNT - (boatTag - 1)))
                {
                    for (int i = 0; i < boatTag; i++)
                    {
                        Control btnNext = tlpPersonalGrid.Controls[btnIndex + lineBreak * i];
                        for (int j = 0; j < boatTag; j++)
                        {
                            Control btnNextTemp = tlpPersonalGrid.Controls[btnIndex + lineBreak * j];
                            if (btnNextTemp.BackColor == Color.Black)
                            {
                                cmptDisponibleSpace++;
                            }
                        }
                        if (cmptDisponibleSpace == 0)
                        {
                            btnNext.AllowDrop = true;
                            btnNext.BackColor = Color.Yellow;
                        }
                        else
                        {
                            btnNext.AllowDrop = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < boatTag; i++)
                    {
                        if (tlpPersonalGrid.Controls.Count - btnIndex >= boatTag)
                        {
                            if (btnIndex + lineBreak * i < COLUMN_COUNT * ROW_COUNT)
                            {
                                Control btnNext = tlpPersonalGrid.Controls[btnIndex + lineBreak * i];
                                btnNext.AllowDrop = false;
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Permet de réinitialiser la forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            initializeAllGrids();
            btnReadyAndNewGame.Enabled = false;
            listPorteAvion.Clear();
            listCroiseur.Clear();
            listContreTorpilleur.Clear();
            listSousMarin.Clear();
            listTorpilleur.Clear();
            listpositionPorteAvionToSink.Clear();
            listpositionCroiseurToSink.Clear();
            listpositionContreTorpilleurToSink.Clear();
            listpositionSousMarinToSink.Clear();
            listpositionTorpilleurToSink.Clear();
        }

        /// <summary>
        /// Quand la touche Ctrl est appuyée, le bateau se met à la verticale. 
        /// Quand la touche Alt est appuyée, le bateau se met à l'horizontale. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPorteAvion_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            //touche Ctrl
            if (e.KeyState == 33)
            {
                isVertical = false;
            }

            //touche alt
            if (e.KeyState == 9)
            {
                isVertical = true;
            }
        }

        /// <summary>
        /// Quand le texte du bouton vaut "Prêt", il Confirme que le placement des bateaux est correct et que la partie peut commencer
        /// Quand le texte du bouton vaut "Nouvelle Partie", il permet de commencer une nouvelle partie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadyAndNewGame_Click(object sender, EventArgs e)
        {

            if (btnReadyAndNewGame.Text == "Prêt")
            {
                client.WriteLine("not" + "Prêt");
                lblMessages.Text = "En attente de l'autre joueur ...";
                btnReadyAndNewGame.Text = "Nouvelle Partie";
                btnReadyAndNewGame.Enabled = false;
                btnReset.Enabled = false;
                tmrScore.Start();
                tmrReady.Start();

                if (opponentReady)
                {
                    myTurn = false;
                }
                else
                {
                    myTurn = true;
                }
            }
            else if (btnReadyAndNewGame.Text == "Nouvelle Partie")
            {
                Controls.Clear();
                InitializeComponent();
                initializeAllGrids();
                btnReadyAndNewGame.Enabled = false;
                tmrAutoShootEnable = false;
                cmptTimeToShoot = 60;
                opponentReady = false;
                listPorteAvion.Clear();
                listCroiseur.Clear();
                listContreTorpilleur.Clear();
                listSousMarin.Clear();
                listTorpilleur.Clear();
                listpositionPorteAvionToSink.Clear();
                listpositionCroiseurToSink.Clear();
                listpositionContreTorpilleurToSink.Clear();
                listpositionSousMarinToSink.Clear();
                listpositionTorpilleurToSink.Clear();
            }
        }

        /// <summary>
        /// Permet de gérer les grilles en début de partie.
        /// </summary>
        private void activateGrid()
        {
            tlpPersonalGrid.Invoke((MethodInvoker)delegate ()
            {
                tlpPersonalGrid.Enabled = false;
            });
            tlpOpponentGrid.Invoke((MethodInvoker)delegate ()
            {
                tlpOpponentGrid.Enabled = true;
            });
            pnlRight.Invoke((MethodInvoker)delegate ()
            {
                pnlRight.Enabled = false;
            });

            if (myTurn)
            {
                lblMessages.Text = "La partie peut commencer !" + Environment.NewLine + "À VOTRE TOUR !";
                tmrAutoShootEnable = true;
            }
            else
                lblMessages.Text = "La partie peut commencer !" + Environment.NewLine + "AU TOUR DE L'ADVERSAIRE !";


        }

        /// <summary>
        /// Permet d'afficher le score de telle sorte à ce qu'il soit rafraichît toutes les 100 milisecondes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrScore_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score" + Environment.NewLine + "Vous: " + score.ToString() + " | " + " Adversaire: " + opponentScore;
        }

        /// <summary>
        /// Permet de déterminer si le joueur adverse est prêt à jouer avant d'activer les contrôles de jeu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrReady_Tick(object sender, EventArgs e)
        {
            if (opponentReady)
            {
                activateGrid();
                tmrReady.Stop();
            }
        }

        /// <summary>
        /// Ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {

            this.Close();
        }



        /// <summary>
        /// Avertit l'utilisateur que le formulaire va être fermé et lui laisse la possibilité d'annuler la fermeture. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closingMessageShown)
            {
                DialogResult dr = MessageBox.Show("Voulez-vous vraiment quitter / abandonner ? ", "Quitter l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (opponentReady)
                    {
                        client.WriteLine("not" + "VICTOIRE !");
                    }
                    closingMessageShown = true;
                }
            }
        }

        private void tmrAutoShoot_Tick(object sender, EventArgs e)
        {
            lblTimeToShoot.Text = String.Format("Il vous reste {0} seconde(s) pour jouer", cmptTimeToShoot);
            if (tmrAutoShootEnable)
            {
                if (myTurn)
                {
                    if (cmptBtnToShoot >= 1 && cmptTimeToShoot == 0)
                    {
                        foreach (Button button in listOfAvailableButton)
                        {
                            int randButtonIndex = rndButtonToShoot.Next(1, listOfAvailableButton.Count);
                            if (listOfAvailableButton.Count <= 1)
                            {
                                randButtonIndex = 0;
                            }
                            if (myTurn)
                            {
                                client.WriteLine("sht" + listOfAvailableButton[randButtonIndex].Tag.ToString());
                                tempTag = listOfAvailableButton[randButtonIndex].Tag.ToString();
                            }
                            if (myTurn)
                            {
                                myTurn = false;
                                client.WriteLine("trn" + "true");
                                lblMessages.Text = "AU TOUR DE L'ADVERSAIRE!";
                                listOfAvailableButton.RemoveAt(randButtonIndex);
                                break;
                                // tmrAutoShoot.Stop();
                            }


                        }
                        tmrAutoShootEnable = false;
                        cmptBtnToShoot = 0;
                        cmptTimeToShoot = 60;
                    }

                    cmptTimeToShoot--;
                }
                cmptBtnToShoot++;
            }
        }
    }
}

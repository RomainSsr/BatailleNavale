namespace batailleNavale
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpOpponentGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTorpilleur = new System.Windows.Forms.Button();
            this.btnSousMarin = new System.Windows.Forms.Button();
            this.btnContreTorpilleur = new System.Windows.Forms.Button();
            this.btnCroiseur = new System.Windows.Forms.Button();
            this.btnPorteAvion = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReadyAndNewGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tlpPersonalGrid = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLettersOpponent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNumbersOpponent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNumbersPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLettersPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessages = new System.Windows.Forms.Label();
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.lsbMessages = new System.Windows.Forms.ListBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrReady = new System.Windows.Forms.Timer(this.components);
            this.tmrAutoShoot = new System.Windows.Forms.Timer(this.components);
            this.pnlRight.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOpponentGrid
            // 
            this.tlpOpponentGrid.ColumnCount = 10;
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.Enabled = false;
            this.tlpOpponentGrid.Location = new System.Drawing.Point(51, 66);
            this.tlpOpponentGrid.Name = "tlpOpponentGrid";
            this.tlpOpponentGrid.RowCount = 10;
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOpponentGrid.Size = new System.Drawing.Size(394, 362);
            this.tlpOpponentGrid.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.btnReset);
            this.pnlRight.Controls.Add(this.btnTorpilleur);
            this.pnlRight.Controls.Add(this.btnSousMarin);
            this.pnlRight.Controls.Add(this.btnContreTorpilleur);
            this.pnlRight.Controls.Add(this.btnCroiseur);
            this.pnlRight.Controls.Add(this.btnPorteAvion);
            this.pnlRight.Location = new System.Drawing.Point(921, 66);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(259, 523);
            this.pnlRight.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.AllowDrop = true;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(168, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 31);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTorpilleur
            // 
            this.btnTorpilleur.Location = new System.Drawing.Point(91, 357);
            this.btnTorpilleur.Name = "btnTorpilleur";
            this.btnTorpilleur.Size = new System.Drawing.Size(83, 54);
            this.btnTorpilleur.TabIndex = 6;
            this.btnTorpilleur.Tag = "2";
            this.btnTorpilleur.Text = "Toriplleur\r\n2 cases\r\n\r\n";
            this.btnTorpilleur.UseVisualStyleBackColor = true;
            this.btnTorpilleur.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.btnPorteAvion_QueryContinueDrag);
            this.btnTorpilleur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPorteAvion_MouseDown);
            // 
            // btnSousMarin
            // 
            this.btnSousMarin.Location = new System.Drawing.Point(131, 247);
            this.btnSousMarin.Name = "btnSousMarin";
            this.btnSousMarin.Size = new System.Drawing.Size(121, 75);
            this.btnSousMarin.TabIndex = 5;
            this.btnSousMarin.Tag = "3";
            this.btnSousMarin.Text = "Sous-Marin\r\n3 cases\r\n";
            this.btnSousMarin.UseVisualStyleBackColor = true;
            this.btnSousMarin.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.btnPorteAvion_QueryContinueDrag);
            this.btnSousMarin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPorteAvion_MouseDown);
            // 
            // btnContreTorpilleur
            // 
            this.btnContreTorpilleur.Location = new System.Drawing.Point(5, 247);
            this.btnContreTorpilleur.Name = "btnContreTorpilleur";
            this.btnContreTorpilleur.Size = new System.Drawing.Size(121, 75);
            this.btnContreTorpilleur.TabIndex = 4;
            this.btnContreTorpilleur.Tag = "3";
            this.btnContreTorpilleur.Text = "Contre Torpilleur\r\n3 cases\r\n";
            this.btnContreTorpilleur.UseVisualStyleBackColor = true;
            this.btnContreTorpilleur.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.btnPorteAvion_QueryContinueDrag);
            this.btnContreTorpilleur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPorteAvion_MouseDown);
            // 
            // btnCroiseur
            // 
            this.btnCroiseur.Location = new System.Drawing.Point(56, 128);
            this.btnCroiseur.Name = "btnCroiseur";
            this.btnCroiseur.Size = new System.Drawing.Size(146, 75);
            this.btnCroiseur.TabIndex = 3;
            this.btnCroiseur.Tag = "4";
            this.btnCroiseur.Text = "Croiseur\r\n4 cases\r\n";
            this.btnCroiseur.UseVisualStyleBackColor = true;
            this.btnCroiseur.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.btnPorteAvion_QueryContinueDrag);
            this.btnCroiseur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPorteAvion_MouseDown);
            // 
            // btnPorteAvion
            // 
            this.btnPorteAvion.Location = new System.Drawing.Point(28, 14);
            this.btnPorteAvion.Name = "btnPorteAvion";
            this.btnPorteAvion.Size = new System.Drawing.Size(202, 75);
            this.btnPorteAvion.TabIndex = 2;
            this.btnPorteAvion.Tag = "5";
            this.btnPorteAvion.Text = "Porte-Avion\r\n5 cases\r\n";
            this.btnPorteAvion.UseVisualStyleBackColor = true;
            this.btnPorteAvion.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.btnPorteAvion_QueryContinueDrag);
            this.btnPorteAvion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPorteAvion_MouseDown);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(449, 533);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 22);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            // 
            // btnReadyAndNewGame
            // 
            this.btnReadyAndNewGame.Enabled = false;
            this.btnReadyAndNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyAndNewGame.Location = new System.Drawing.Point(51, 558);
            this.btnReadyAndNewGame.Name = "btnReadyAndNewGame";
            this.btnReadyAndNewGame.Size = new System.Drawing.Size(160, 31);
            this.btnReadyAndNewGame.TabIndex = 6;
            this.btnReadyAndNewGame.Text = "Prêt";
            this.btnReadyAndNewGame.UseVisualStyleBackColor = true;
            this.btnReadyAndNewGame.Click += new System.EventHandler(this.btnReadyAndNewGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AllowDrop = true;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(790, 558);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 31);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tlpPersonalGrid
            // 
            this.tlpPersonalGrid.AllowDrop = true;
            this.tlpPersonalGrid.ColumnCount = 10;
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.Location = new System.Drawing.Point(486, 66);
            this.tlpPersonalGrid.Name = "tlpPersonalGrid";
            this.tlpPersonalGrid.RowCount = 10;
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPersonalGrid.Size = new System.Drawing.Size(394, 362);
            this.tlpPersonalGrid.TabIndex = 1;
            // 
            // tlpLettersOpponent
            // 
            this.tlpLettersOpponent.ColumnCount = 1;
            this.tlpLettersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLettersOpponent.Location = new System.Drawing.Point(25, 66);
            this.tlpLettersOpponent.Name = "tlpLettersOpponent";
            this.tlpLettersOpponent.RowCount = 10;
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersOpponent.Size = new System.Drawing.Size(26, 362);
            this.tlpLettersOpponent.TabIndex = 9;
            // 
            // tlpNumbersOpponent
            // 
            this.tlpNumbersOpponent.ColumnCount = 10;
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersOpponent.Location = new System.Drawing.Point(51, 38);
            this.tlpNumbersOpponent.Name = "tlpNumbersOpponent";
            this.tlpNumbersOpponent.RowCount = 1;
            this.tlpNumbersOpponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNumbersOpponent.Size = new System.Drawing.Size(394, 30);
            this.tlpNumbersOpponent.TabIndex = 10;
            // 
            // tlpNumbersPersonal
            // 
            this.tlpNumbersPersonal.ColumnCount = 10;
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNumbersPersonal.Location = new System.Drawing.Point(486, 38);
            this.tlpNumbersPersonal.Name = "tlpNumbersPersonal";
            this.tlpNumbersPersonal.RowCount = 1;
            this.tlpNumbersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNumbersPersonal.Size = new System.Drawing.Size(394, 30);
            this.tlpNumbersPersonal.TabIndex = 11;
            // 
            // tlpLettersPersonal
            // 
            this.tlpLettersPersonal.ColumnCount = 1;
            this.tlpLettersPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLettersPersonal.Location = new System.Drawing.Point(459, 66);
            this.tlpLettersPersonal.Name = "tlpLettersPersonal";
            this.tlpLettersPersonal.RowCount = 10;
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLettersPersonal.Size = new System.Drawing.Size(26, 362);
            this.tlpLettersPersonal.TabIndex = 12;
            // 
            // lblMessages
            // 
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(51, 445);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(829, 88);
            this.lblMessages.TabIndex = 13;
            this.lblMessages.Text = "Placez les bateaux sur la grille de droite et cliquez sur \"Prêt\" pour commencer";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrScore
            // 
            this.tmrScore.Tick += new System.EventHandler(this.tmrScore_Tick);
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.tbxMessage);
            this.gbChat.Controls.Add(this.lsbMessages);
            this.gbChat.Controls.Add(this.btnSendMessage);
            this.gbChat.Location = new System.Drawing.Point(921, 605);
            this.gbChat.Name = "gbChat";
            this.gbChat.Size = new System.Drawing.Size(259, 352);
            this.gbChat.TabIndex = 15;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(15, 320);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(160, 20);
            this.tbxMessage.TabIndex = 3;
            // 
            // lsbMessages
            // 
            this.lsbMessages.FormattingEnabled = true;
            this.lsbMessages.Location = new System.Drawing.Point(15, 19);
            this.lsbMessages.Name = "lsbMessages";
            this.lsbMessages.Size = new System.Drawing.Size(235, 290);
            this.lsbMessages.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(178, 320);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(72, 20);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Envoyer";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 637);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(455, 318);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Règles du jeu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ctrl = Vertical        Alt = Horizontal";
            // 
            // tmrReady
            // 
            this.tmrReady.Tick += new System.EventHandler(this.tmrReady_Tick);
            // 
            // tmrAutoShoot
            // 
            this.tmrAutoShoot.Enabled = true;
            this.tmrAutoShoot.Interval = 1500;
            this.tmrAutoShoot.Tick += new System.EventHandler(this.tmrAutoShoot_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 973);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.tlpLettersPersonal);
            this.Controls.Add(this.tlpNumbersPersonal);
            this.Controls.Add(this.tlpNumbersOpponent);
            this.Controls.Add(this.tlpLettersOpponent);
            this.Controls.Add(this.tlpPersonalGrid);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReadyAndNewGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.tlpOpponentGrid);
            this.Name = "frmMain";
            this.Text = "Bataille Navale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.batailleNavale_Load);
            this.pnlRight.ResumeLayout(false);
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOpponentGrid;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReadyAndNewGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TableLayoutPanel tlpPersonalGrid;
        private System.Windows.Forms.TableLayoutPanel tlpLettersOpponent;
        private System.Windows.Forms.TableLayoutPanel tlpNumbersOpponent;
        private System.Windows.Forms.TableLayoutPanel tlpNumbersPersonal;
        private System.Windows.Forms.TableLayoutPanel tlpLettersPersonal;
        private System.Windows.Forms.Button btnPorteAvion;
        private System.Windows.Forms.Button btnTorpilleur;
        private System.Windows.Forms.Button btnSousMarin;
        private System.Windows.Forms.Button btnContreTorpilleur;
        private System.Windows.Forms.Button btnCroiseur;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.ListBox lsbMessages;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrReady;
        private System.Windows.Forms.Timer tmrAutoShoot;
    }
}


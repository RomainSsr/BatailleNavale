using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UDPListenerUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Thread firstTrhead; 
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private const int listenPort = 11000;
        UdpClient listener = new UdpClient(listenPort);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
        string received_data;
        byte[] receive_byte_array;
        int cmpt = 0;
        private void btnStartListener_Click(object sender, EventArgs e)
        {

            lblListenerStatus.Text = "Listener Activé";
           
            firstTrhead = new Thread(new ThreadStart(NetworkDiscovery));
            firstTrhead.Start();
        }

        private void btnStopListener_Click(object sender, EventArgs e)
        {
            lblListenerStatus.Text = "Listener Désactivé";
            tmrNetworkDicovery.Stop();
            firstTrhead.Suspend();
        }

        private void tmrNetworkDicovery_Tick(object sender, EventArgs e)
        {


            cmpt++;
            label1.Text = cmpt.ToString();
            //listener.Close();
        }
        private void NetworkDiscovery()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                // this is the line of code that receives the broadcase message.
                // It calls the receive function from the object listener (class UdpClient)
                // It passes to listener the end point groupEP.
                // It puts the data from the broadcast message into the byte array
                // named received_byte_array.
                // I don't know why this uses the class UdpClient and IPEndPoint like this.
                // Contrast this with the talker code. It does not pass by reference.
                // Note that this is a synchronous or blocking call.
                receive_byte_array = listener.Receive(ref groupEP);

                received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                if (received_data != "")
                {

                    bool doublon = false;
                    foreach (var element in lsbServerDispo.Items)
                    {
                        if (element.ToString() == received_data)
                        {
                            doublon = true;
                        }
                    }
                    if (!doublon)
                    {
                        lsbServerDispo.Invoke((MethodInvoker)delegate ()
                        {
                            lsbServerDispo.Items.Add(received_data);
                        });
                    }
                }
            }

        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            lsbServerDispo.Items.Clear();
        }

    }
}

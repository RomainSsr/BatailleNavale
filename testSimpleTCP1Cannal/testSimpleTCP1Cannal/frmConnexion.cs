using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace testSimpleTCP1Cannal
{
    public partial class frmConnexion : Form
    {
        Thread firstTrhead;
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private const int listenPort = 1001;
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
            firstTrhead.Suspend();
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
                    foreach (var element in lsbAvailableServer.Items)
                    {
                        if (element.ToString() == received_data)
                        {
                            doublon = true;
                        }
                    }
                    if (!doublon)
                    {
                        lsbAvailableServer.Invoke((MethodInvoker)delegate ()
                        {
                            lsbAvailableServer.Items.Add(received_data);
                        });
                    }
                }
            }

        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            lsbAvailableServer.Items.Clear();
        }


        public frmConnexion()
        {
            InitializeComponent();

        }
        UDPBroadcaster serverUDP = new UDPBroadcaster();
        UDPListener listenerUDP = new UDPListener();
        static private SimpleTcpServer _server;
        static private SimpleTcpClient _client;
        private void frmConnexion_Load(object sender, EventArgs e)
        {
            tbxServerIP.Text = GetLocalIPAddress();
            tbxClientIP.Text = GetLocalIPAddress();
        }
        static public SimpleTcpServer SERVER
        {
            get
            {
                return _server;
            }
        }

        static public SimpleTcpClient CLIENT
        {
            get
            {
                return _client;
            }
        }


        private void Connexion_Load(object sender, EventArgs e)
        {
            _server = new SimpleTcpServer();
            _server.Delimiter = 0x13;//enter
            _server.StringEncoder = Encoding.UTF8;

            _client = new SimpleTcpClient();
            _client.StringEncoder = Encoding.UTF8;

        }



        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Adresse IP locale introuvable! ");
        }

        
            

        private void btnConnect_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(GetLocalIPAddress());
            _server.Start(ip, Convert.ToInt32(tbxServerPort.Text));
        
           //string AvailableServer = listenerUDP.NetworkDiscovery();

            /*bool doublon = false;
            foreach (var element in cbxAvaiableServers.Items)
            {
                if (element.ToString() == AvailableServer)
                {
                    doublon = true;
                }
            }
            if (!doublon)
            {
            }
                lsbAvailableServer.Items.Add(AvailableServer);*/


        

        /*_client.Connect(tbxClientIP.Text, Convert.ToInt32(cbxAvaiableServers.Tag.ToString()));
        this.Visible = false;*/
    }
        

        private void btStartSever_Click(object sender, EventArgs e)
        {
            serverUDP.initServer();
        }

        private void tmrBroadcast_Tick(object sender, EventArgs e)
        {
        }

        private void pibRefresh_Click(object sender, EventArgs e)
        {
            tmrBroadcast.Enabled = true;
        }

        private void btnConnectClient_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}

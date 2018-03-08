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

namespace testSimpleTCP1Cannal
{
    public partial class frmConnexion : Form
    {
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(GetLocalIPAddress());
            _server.Start(ip, Convert.ToInt32(tbxServerPort.Text));
            lblServerState.Text = "Serveur Démarré";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            listenerUDP.InitClient();
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
    }
}

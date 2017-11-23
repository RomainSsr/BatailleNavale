using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batailleNavale
{
    public partial class frmConnexion : Form
    {
        frmMain f; 
        static private SimpleTcpServer _server;
        static private SimpleTcpClient _client;
        static private TextBox _tbxClientIp;
        static public TextBox TBX_IP_CLIENT
        {
            get
            {
                return _tbxClientIp;
            }
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

        public frmConnexion()
        {
            InitializeComponent();
            f = new frmMain(this);
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            _server = new SimpleTcpServer();
            _server.Delimiter = 0x13;//enter
            _server.StringEncoder = Encoding.UTF8;

            _client = new SimpleTcpClient();
            _client.StringEncoder = Encoding.UTF8;

            tbxLocalIp.Text = GetLocalIPAddress();
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
            throw new Exception("Local IP Address Not Found!");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblServerStatus.Text = "Serveur Started";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(tbxLocalIp.Text);
            _server.Start(ip, Convert.ToInt32(tbxLocalPort.Text));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _client.Connect(tbxClientIp.Text, Convert.ToInt32(tbxClientPort.Text));
            _tbxClientIp = tbxClientIp;
            AutoClosingMessageBox.Show("Connecté", "État de la connexion", 1000);
            this.Visible = false;
            f.Show();
        }

        public void ReloadMain()
        {
            f.Hide();
            frmMain frm = new frmMain(this);
            frm.Show();
            f.Dispose();
        }
    }
}

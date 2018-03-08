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

        bool done = false;
        #region comments
        // Create a socket object. This is the fundamental device used to network
        // communications. When creating this object we specify:
        // Internetwork: We use the internet communications protocol
        // Dgram: We use datagrams or broadcast to everyone rather than send to
        // a specific listener
        // UDP: the messages are to be formated as user datagram protocal.
        // The last two seem to be a bit redundant.
        #endregion
        Socket sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
        ProtocolType.Udp);
        #region comments 
        // create an address object and populate it with the IP address that we will use
        // in sending at data to. This particular address ends in 255 meaning we will send
        // to all devices whose address begins with 192.168.2.
        // However, objects of class IPAddress have other properties. In particular, the
        // property AddressFamily. Does this constructor examine the IP address being
        // passed in, determine that this is IPv4 and set the field. If so, the notes
        // in the help file should say so.
        #endregion
        static IPAddress send_to_address = IPAddress.Parse("10.134.99.255");

        #region comments
        // IPEndPoint appears (to me) to be a class defining the first or final data
        // object in the process of sending or receiving a communications packet. It
        // holds the address to send to or receive from and the port to be used. We create
        // this one using the address just built in the previous line, and adding in the
        // port number. As this will be a broadcase message, I don't know what role the
        // port number plays in this.
        #endregion
        IPEndPoint sending_end_point = new IPEndPoint(send_to_address, 11000);
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
            gbClient.Enabled = false;
            tmrBroadcastIp.Start();
            lblServerStatus.Text = "Serveur Started";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(tbxLocalIp.Text);
            _server.Start(ip, Convert.ToInt32(tbxLocalPort.Text));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /*_client.Connect(tbxClientIp.Text, Convert.ToInt32(tbxClientPort.Text));
            _tbxClientIp = tbxClientIp;
            AutoClosingMessageBox.Show("Connecté", "État de la connexion", 1000);*/
            this.Visible = false;
            f.Show();
        }

        private void tmrBroadcastIp_Tick(object sender, EventArgs e)
        {
            string myIp = GetLocalIPAddress();

            if (myIp.Length == 0)
            {
                done = true;
            }
            else
            {
                // the socket object must have an array of bytes to send.
                // this loads the string entered by the user into an array of bytes.
                byte[] send_buffer = Encoding.ASCII.GetBytes(myIp);

                // Remind the user of where this is going.
                Console.WriteLine("sending to address: {0} port: {1}",
                sending_end_point.Address,
                sending_end_point.Port);
                try
                {
                    sending_socket.SendTo(send_buffer, sending_end_point);
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.ToString();
                }
               
            }
        }
    }
}

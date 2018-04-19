using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

        #region client
        //variables pour UDP client
        Thread firstTrhead;
        private const int listenPort = 1001;
        UdpClient listener = new UdpClient(listenPort);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
        string received_data;
        byte[] receive_byte_array;
        #endregion

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
        static IPAddress send_to_address = Broadcast.GetBroadcastAddress(GetLocalIPAddress(), GetSubnetMask(GetLocalIPAddress()));

        #region comments
        // IPEndPoint appears (to me) to be a class defining the first or final data
        // object in the process of sending or receiving a communications packet. It
        // holds the address to send to or receive from and the port to be used. We create
        // this one using the address just built in the previous line, and adding in the
        // port number. As this will be a broadcase message, I don't know what role the
        // port number plays in this.
        #endregion
        IPEndPoint sending_end_point = new IPEndPoint(send_to_address, listenPort);
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
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            _server = new SimpleTcpServer();
            _server.Delimiter = 0x13;//enter
            _server.StringEncoder = Encoding.UTF8;

            _client = new SimpleTcpClient();
            _client.StringEncoder = Encoding.UTF8;

            tbxLocalIp.Text = GetLocalIPAddress().ToString();
            tbxLocalPort.Text = listenPort.ToString();
        }



        public static IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public static IPAddress GetSubnetMask(IPAddress address)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            return unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
            throw new ArgumentException(string.Format("Can't find subnetmask for IP address '{0}'", address));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            f = new frmMain(this, true);
            gbClient.Enabled = false;
            btnStart.Enabled = false;
            tmrBroadcastIp.Start();
            lblServerStatus.Text = "Serveur Started";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(tbxLocalIp.Text);
            _server.Start(ip, Convert.ToInt32(tbxLocalPort.Text));
            _server.ClientConnected += _server_ClientConnected;
        }
        private void btnStopServer_Click(object sender, EventArgs e)
        {
            f.Dispose();
            gbClient.Enabled = true;
            btnStart.Enabled = true;
            tmrBroadcastIp.Stop();
            lblServerStatus.Text = "Serveur Stopped";
            IPAddress myIP = GetLocalIPAddress();
            string myIPString = myIP.ToString() + ";STOP";
            byte[] send_buffer = Encoding.ASCII.GetBytes(myIPString);

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
                //lblError.Text = ex.ToString();
            }
            _server.Stop();
        }

        private void _server_ClientConnected(object sender, TcpClient e)
        {

            tmrBroadcastIp.Stop();
            SendStop();
            
            

            this.Invoke((MethodInvoker)delegate ()
            {
                this.Visible = false;
                f.Show();
            });
        }

        private void SendStop()
        {
            IPAddress myIP = GetLocalIPAddress();
            string myIPString = myIP.ToString() + ";STOP";
            byte[] send_buffer = Encoding.ASCII.GetBytes(myIPString);

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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnStopListen.PerformClick();
            f = new frmMain(this, false);
            _client.Connect(lsbAvaiableServers.SelectedItem.ToString(), Convert.ToInt32(listenPort));
            // _tbxClientIp = tbxClientIp;
            // AutoClosingMessageBox.Show("Connecté", "État de la connexion", 1000);
            this.Visible = false;
            f.Show();
        }

        private void tmrBroadcastIp_Tick(object sender, EventArgs e)
        {
            IPAddress myIP = GetLocalIPAddress();
            string myIPString = myIP.ToString() + ";OK";
            if (myIPString != "")
            {

                // the socket object must have an array of bytes to send.
                // this loads the string entered by the user into an array of bytes.
                byte[] send_buffer = Encoding.ASCII.GetBytes(myIPString);

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
                    //lblError.Text = ex.ToString();
                }
            }

        }

        private void btnStartListen_Click(object sender, EventArgs e)
        {
            lblClientInfo.Text = "Listener Activé";

            firstTrhead = new Thread(new ThreadStart(NetworkDiscovery));
            firstTrhead.Start();
        }

        private void btnStopListen_Click(object sender, EventArgs e)
        {
            lblClientInfo.Text = "Listener Désactivé";
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
                string[] received_data_string = received_data.Split(';');
                if (received_data_string[0] != "")
                {
                    if (received_data_string[1] != "STOP")
                    {
                        bool doublon = false;
                        foreach (var element in lsbAvaiableServers.Items)
                        {
                            if (element.ToString() == received_data_string[0])
                            {
                                doublon = true;
                            }
                        }
                        if (!doublon)
                        {
                            lsbAvaiableServers.Invoke((MethodInvoker)delegate ()
                            {
                                lsbAvaiableServers.Items.Add(received_data_string[0]);
                            });
                        }
                    }
                    else
                    {
                        lsbAvaiableServers.Invoke((MethodInvoker)delegate ()
                        {
                            lsbAvaiableServers.Items.Remove(received_data_string[0]);
                        });
                    }
                }
            }

        }

        private void lsbAvaiableServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
        }

    }
}

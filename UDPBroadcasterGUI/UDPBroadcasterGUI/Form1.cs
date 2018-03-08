using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPBroadcasterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean done = false;
        Boolean exception_thrown = false;
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
       static  IPAddress send_to_address = IPAddress.Parse("10.134.99.255");

        #region comments
        // IPEndPoint appears (to me) to be a class defining the first or final data
        // object in the process of sending or receiving a communications packet. It
        // holds the address to send to or receive from and the port to be used. We create
        // this one using the address just built in the previous line, and adding in the
        // port number. As this will be a broadcase message, I don't know what role the
        // port number plays in this.
        #endregion
        IPEndPoint sending_end_point = new IPEndPoint(send_to_address, 11000);

        private void btnSend_Click(object sender, EventArgs e)
        {
            
                string text_to_send = tbxTextToSend.Text;
                if (text_to_send.Length == 0)
                {
                    done = true;
                }
                else
                {
                    // the socket object must have an array of bytes to send.
                    // this loads the string entered by the user into an array of bytes.
                    byte[] send_buffer = Encoding.ASCII.GetBytes(text_to_send);

                    // Remind the user of where this is going.
                    Console.WriteLine("sending to address: {0} port: {1}",
                    sending_end_point.Address,
                    sending_end_point.Port);
                    try
                    {
                        sending_socket.SendTo(send_buffer, sending_end_point);
                    }
                    catch (Exception send_exception)
                    {
                        exception_thrown = true;
                       lsbNotification.Items.Add(string.Format(" Exception {0}", send_exception.Message));
                    }
                    if (exception_thrown == false)
                    {
                        lsbNotification.Items.Add(string.Format("Message has been sent to the broadcast address"));
                    }
                    else
                    {
                        exception_thrown = false;
                        lsbNotification.Items.Add(string.Format("The exception indicates the message was not sent."));
                    }
                }
                tbxTextToSend.Text = "";
             // end of while (!done)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbxTextToSend.Text = GetLocalIPAddress();
            btnSend.PerformClick();
        }
    }
}

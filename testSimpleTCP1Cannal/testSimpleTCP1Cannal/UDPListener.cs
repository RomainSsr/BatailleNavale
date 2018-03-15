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

public class UDPListener
{
   /* private const int listenPort = 9999;

    UdpClient listener = new UdpClient(listenPort);
    IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
    string received_data;
    byte[] receive_byte_array;
    public void btnStartListener_Click(object sender, EventArgs e)
    {

        // lblListenerStatus.Text = "Listener Activé";

    }

    public void btnStopListener_Click(object sender, EventArgs e)
    {
        //lblListenerStatus.Text = "Listener Désactivé";
        //tmrNetworkDicovery.Stop();
    }


    public string NetworkDiscovery()
    {
        receive_byte_array = listener.Receive(ref groupEP);

        received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);

        return received_data;

    }*/

}


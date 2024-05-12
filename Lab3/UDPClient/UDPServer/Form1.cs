using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPServer
{
    public partial class Form1 : Form
    {
        public bool ThreadCalls { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            int port = Convert.ToInt32(textBox1.Text);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);
                
                Byte[] recvBytes = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(recvBytes);
                string mess = IpEnd.Address.ToString() + ":" +

                IpEnd.Port.ToString() + ": " + Data.ToString();

                
                InfoMessage(mess);
            }
        }
        private void InfoMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(InfoMessage), message);
                return;
            }
            
            richTextBox1.AppendText(message + Environment.NewLine);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Task.Run(() => serverThread());
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();

            IPAddress ipadd = IPAddress.Parse(tbHost.Text);
            int port = Convert.ToInt32(tbPort.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            
            Byte[] sendBytes =
            Encoding.UTF8.GetBytes(richTextBox1.Text);
            
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
            
            richTextBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

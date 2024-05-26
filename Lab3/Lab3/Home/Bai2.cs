using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                            AddressFamily.InterNetwork,
                            SocketType.Stream,
                            ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("192.168.1.135"), 9999);
            // Bind the listening socket to the specified IP address and port 8080
            listenerSocket.Bind(ipepServer);
            // Start listening. Socket.Listen(int backlog)
            // backlog: maximum length of the pending connections queue
            listenerSocket.Listen(-1);
            // Accept incoming connection
            clientSocket = listenerSocket.Accept();
            AddListViewItem("New client connected");
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    try
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.ASCII.GetString(recv);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Handle InvalidOperationException (cross-thread UI access)
                        Console.WriteLine("Error: " + ex.Message);
                    }
                } while (text[text.Length - 1] != '\n');
                AddListViewItem(text);
                Console.WriteLine(" ");
            }
            listenerSocket.Close();
        }

        private void AddListViewItem(string text)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke((MethodInvoker)delegate {
                    listView.Items.Add(text);
                });
            }
            else
            {
                listView.Items.Add(text);
            }
        }

        private void button1_exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

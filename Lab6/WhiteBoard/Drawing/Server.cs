using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Server : Form
    {
        private Socket serverSocket;
        private List<Socket> clientSockets = new List<Socket>();
        private byte[] buffer = new byte[1024];
        private int clientCount = 0;

        public Server()
        {
            InitializeComponent();
            SetupServer();
        }

        private void SetupServer()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100)); // Lắng nghe trên cổng 100
            serverSocket.Listen(10);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = serverSocket.EndAccept(AR);
            clientSockets.Add(socket);
            clientCount++;
            UpdateClientCount();
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;
            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                // Client forcefully disconnected
                current.Close();
                clientSockets.Remove(current);
                clientCount--;
                UpdateClientCount();
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            // Broadcast the received data to all clients
            foreach (Socket socket in clientSockets)
            {
                if (socket != current)
                {
                    socket.Send(recBuf);
                }
            }

            current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), current);
        }

        private void UpdateClientCount()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateClientCount));
                return;
            }
            tb_client.Text = clientCount.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            serverSocket.Close();
            base.OnFormClosing(e);
        }
    }
}

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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void StartListen_Click_1(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.Start();
        }

        private void StartServer()
        {
            byte[] recv = new byte[1024]; 
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Invoke((MethodInvoker)delegate
            {
                AddMessageToListView("Server listening on port 8080...");
            });

            clientSocket = listenerSocket.Accept();

           
            AddMessageToListView("New client connected.");

            
            while (clientSocket.Connected)
            {
                try
                {
                    int bytesReceived = clientSocket.Receive(recv);
                    string text = Encoding.ASCII.GetString(recv, 0, bytesReceived);

                    
                    if (text.EndsWith("\n") || text.EndsWith("\r"))
                    {
                        text = text.Trim();
                        AddMessageToListView(text);
                    }
                }
                catch (SocketException ex)
                {
                    AddMessageToListView("Socket exception: " + ex.Message);
                    break;
                }
            }

            clientSocket.Close();
            listenerSocket.Close();
        }

        private void AddMessageToListView(string message)
        {
            if (listViewCommand.InvokeRequired)
            {
                listViewCommand.Invoke(new MethodInvoker(() =>
                {
                    listViewCommand.Items.Add(new ListViewItem(message));
                }));
            }
            else
            {
                listViewCommand.Items.Add(new ListViewItem(message));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
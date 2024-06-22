using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Client : Form
    {
        private Graphics graphics;
        private Pen cursorPen = new Pen(Color.Black, 2);
        private bool drawing = false;
        private TcpClient clientSocket = new TcpClient();
        private NetworkStream serverStream;
        private Thread clientThread;

        public Client()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 100); // Địa chỉ và cổng của server
                serverStream = clientSocket.GetStream();
                clientThread = new Thread(GetServerResponse);
                clientThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to server: " + ex.Message);
            }
        }

        private void GetServerResponse()
        {
            while (true)
            {
                byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.ASCII.GetString(inStream);
                string[] tokens = returndata.Split(':');
                if (tokens[0] == "DRAW")
                {
                    string[] coords = tokens[1].Split(',');
                    int x = int.Parse(coords[0]);
                    int y = int.Parse(coords[1]);
                    Invoke(new Action(() =>
                    {
                        graphics.DrawEllipse(cursorPen, x, y, 2, 2);
                    }));
                }
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    cursorPen.Color = colorDialog.Color;
                }
            }
        }

        private void board_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void board_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                graphics = board.CreateGraphics();
                graphics.DrawEllipse(cursorPen, e.X, e.Y, 2, 2);
                string sendData = $"DRAW:{e.X},{e.Y}";
                byte[] outStream = Encoding.ASCII.GetBytes(sendData);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }
        }
    }
}

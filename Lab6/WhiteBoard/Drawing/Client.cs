using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Client : Form
    {
        private TcpClient clientSocket = new TcpClient();
        private NetworkStream serverStream;
        private Thread clientThread;
        private Graphics g;
        private bool drawing = false;
        private Point previousPoint;
        private Pen currentPen;

        public Client()
        {
            InitializeComponent();
            g = board.CreateGraphics();
            currentPen = new Pen(Color.Black, 2);
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
                int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                if (bytesRead > 0)
                {
                    MemoryStream ms = new MemoryStream(inStream, 0, bytesRead);
                    BinaryReader br = new BinaryReader(ms);

                    int startX = br.ReadInt32();
                    int startY = br.ReadInt32();
                    int endX = br.ReadInt32();
                    int endY = br.ReadInt32();
                    Color color = Color.FromArgb(br.ReadInt32());
                    float width = br.ReadSingle();

                    Pen pen = new Pen(color, width);

                    Invoke(new Action(() =>
                    {
                        g.DrawLine(pen, new Point(startX, startY), new Point(endX, endY));
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
                    currentPen.Color = colorDialog.Color;
                }
            }
        }

        private void board_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
        }

        private void board_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                g.DrawLine(currentPen, previousPoint, e.Location);
                SendDrawData(previousPoint, e.Location);
                previousPoint = e.Location;
            }
        }

        private void SendDrawData(Point start, Point end)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(start.X);
            bw.Write(start.Y);
            bw.Write(end.X);
            bw.Write(end.Y);
            bw.Write(currentPen.Color.ToArgb());
            bw.Write(currentPen.Width);
            byte[] data = ms.ToArray();
            serverStream.Write(data, 0, data.Length);
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(board.Width, board.Height);
            board.DrawToBitmap(bitmap, new Rectangle(0, 0, board.Width, board.Height));
            bitmap.Save("whiteboard.png", System.Drawing.Imaging.ImageFormat.Png);
            clientSocket.Close();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private Bitmap offScreenBitmap;
        private Graphics offScreenGraphics;

        public Client()
        {
            InitializeComponent();
            trackBar_penWidth.ValueChanged += trackBar_penWidth_ValueChanged;
            int boldPen = trackBar_penWidth.Value;
            offScreenBitmap = new Bitmap(board.Width, board.Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            g = board.CreateGraphics();
            currentPen = new Pen(Color.Black, boldPen);
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
                        offScreenGraphics.DrawLine(pen, new Point(startX, startY), new Point(endX, endY));
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
            currentPen.Width = trackBar_penWidth.Value;
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
                offScreenGraphics.DrawLine(currentPen, previousPoint, e.Location);
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Lưu bản vẽ";
                saveFileDialog.InitialDirectory = @"C:\Users\MSI\Downloads"; // Tùy chọn: Đặt thư mục ban đầu

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu bitmap ngoài màn hình vào đường dẫn được chỉ định
                    try
                    {
                        offScreenBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show($"Ảnh đã được lưu thành công tại {saveFileDialog.FileName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lưu ảnh thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Giải phóng tài nguyên
                        offScreenGraphics.Dispose();
                        offScreenBitmap.Dispose();

                        if (clientSocket != null)
                        {
                            clientSocket.Close();
                            clientSocket = null;
                        }

                        if (clientThread != null)
                        {
                            clientThread.Abort();
                            clientThread = null;
                        }

                        // Đóng form
                        this.Close();
                    }
                }
            }
            }

        private void trackBar_penWidth_ValueChanged(object sender, EventArgs e)
        {
            currentPen.Width = trackBar_penWidth.Value;
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh để chèn";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Đọc tệp ảnh và hiển thị lên PictureBox
                        Image image = Image.FromFile(openFileDialog.FileName);
                        g.DrawImage(image, 5, 5);
                        SendImageData(image);

                        // Có thể thêm code để gửi ảnh này đến server nếu cần
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể mở ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SendImageData(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] data = ms.ToArray();
            ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(data.Length);
            bw.Write(data);
            byte[] buffer = ms.ToArray();
            serverStream.Write(buffer, 0, buffer.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab2_bai1
{
    public partial class Form_bai3 : Form
    {
        public Form_bai3()
        {
            InitializeComponent();
        }
        public void Readfile() {
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string contents = sr.ReadToEnd();
            richTextBox1.Text = contents;
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tmpForm = new Menu();
            tmpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo SaveFileDialog để chọn nơi lưu file
                SaveFileDialog sfd = new SaveFileDialog();

                // Nếu người dùng đã chọn nơi lưu file và nhấn OK
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo StreamWriter để ghi dữ liệu vào file
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Duyệt qua từng dòng trong RichTextBox
                        foreach (string line in richTextBox1.Lines)
                        {
                            // Tách các thành phần trong dòng (số và toán tử)
                            string[] elements = line.Split(' ');

                            // Kiểm tra xem dòng có đúng định dạng không
                            if (elements.Length != 3)
                            {
                                MessageBox.Show($"Dòng không hợp lệ: {line}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            // Lấy các thành phần
                            double operand1 = double.Parse(elements[0]);
                            char operation = char.Parse(elements[1]);
                            double operand2 = double.Parse(elements[2]);

                            // Thực hiện phép tính
                            double result = 0;
                            switch (operation)
                            {
                                case '+':
                                    result = operand1 + operand2;
                                    break;
                                case '-':
                                    result = operand1 - operand2;
                                    break;
                                case '*':
                                    result = operand1 * operand2;
                                    break;
                                case '/':
                                    if (operand2 != 0)
                                    {
                                        result = operand1 / operand2;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Phép chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        continue;
                                    }
                                    break;
                                default:
                                    MessageBox.Show($"Toán tử không hợp lệ: {operation}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                            }

                            // Ghi kết quả vào file
                            sw.WriteLine($"{operand1} {elements[1]} {operand2} = {result}");
                        }
                       
                    }
                    using (StreamReader sr = new StreamReader(sfd.FileName))
                    {
                        string contents = sr.ReadToEnd();
                        richTextBox2.Text = contents;
                    }
                    // Thông báo khi ghi file thành công
                    MessageBox.Show("Kết quả đã được ghi vào file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
    
}

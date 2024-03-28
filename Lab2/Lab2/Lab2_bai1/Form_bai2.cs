using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_bai1
{
    public partial class Form_bai2 : Form
    {
        public Form_bai2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;

            textBox1.Text = ofd.SafeFileName.ToString();
            textBox2.Text = fs.Name.ToString();

            // Count number of character in a file //
            int charCount = content.Length;
            // Đếm dòng
            content = content.Replace("\r\n", "\r");
            textBox3.Text = richTextBox1.Lines.Count().ToString();
            content = content.Replace('\r', ' ');
            // Đếm từ
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            textBox4.Text = source.Count().ToString();
            // Đếm kí tự
            textBox5.Text = charCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tmpForm = new Menu();
            tmpForm.Show();
        }
    }
}

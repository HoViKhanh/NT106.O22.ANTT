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
    public partial class Form_bai1 : Form
    {
        public Form_bai1()
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK )
            {
                string contentToSave = richTextBox1.Text.ToUpper();
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(contentToSave);   
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tmpForm = new Menu();
            tmpForm.Show();
        }
    }
}

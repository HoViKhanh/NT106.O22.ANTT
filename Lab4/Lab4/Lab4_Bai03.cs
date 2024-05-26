using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Bai03 : Form
    {
        
        public Lab4_Bai03()
        {
            InitializeComponent();
        }
        public string MyProperty { get; set; }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tb_dir.Text == "" || tb_url.Text == " ")
                MessageBox.Show("Ô Path hoặc URL đang để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox1.Clear();
            try
            {
                if (!tb_url.Text.StartsWith("http://"))
                    tb_url.Text = tb_url.Text.Insert(0, "http://");

                WebClient client = new WebClient();
                Stream res = client.OpenRead(tb_url.Text);
                client.DownloadFile(tb_url.Text, tb_dir.Text);
                StreamReader reader = new StreamReader(res);
                string line = reader.ReadToEnd();
                richTextBox1.Text = client.DownloadString(tb_url.Text);
            }
            catch (Exception ex) { richTextBox1.AppendText(ex.Message); }
           

            MessageBox.Show("Download thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Lab4_Bai03_Load(object sender, EventArgs e)
        {
            //tb_url.Text = this.MyProperty.ToString();
        }
    }
}

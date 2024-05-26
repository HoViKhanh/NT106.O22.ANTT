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
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }
        public string MyProperty { get; set; }


        private void btn_download_Click_1(object sender, EventArgs e)
        {

            if (tb_dir.Text == "" || tb_url.Text == " ")
                MessageBox.Show("Ô Path hoặc URL đang để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            WebClient client = new WebClient();
            Stream res = client.OpenRead(tb_url.Text);
            client.DownloadFile(tb_url.Text, tb_dir.Text);
            StreamReader reader = new StreamReader(res);
            string line = reader.ReadToEnd();
            richTextBox1.Text = client.DownloadString(tb_url.Text);

            MessageBox.Show("Download thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Download_Load(object sender, EventArgs e)
        {
            tb_url.Text = this.MyProperty.ToString();
        }
    }
}

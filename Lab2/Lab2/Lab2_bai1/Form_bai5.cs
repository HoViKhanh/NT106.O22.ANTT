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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_bai1
{
    public partial class Form_bai5 : Form
    {
        public Form_bai5()
        {
            InitializeComponent();
            listView1.Columns.Add("Tên File", 300, HorizontalAlignment.Left);
            listView1.Columns.Add("Kích Thước", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Đuôi mở rộng", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Ngày tạo", 200, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles();
                listView1.View = View.Details;
                listView1.GridLines = true;
                foreach (FileInfo file in files)
                {
                    string[] row = { file.Name, file.Length.ToString(), Path.GetExtension(file.Name), file.LastWriteTime.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
            else { MessageBox.Show("Chọn folder"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tmpForm = new Menu();
            tmpForm.Show();
        }
    }
}

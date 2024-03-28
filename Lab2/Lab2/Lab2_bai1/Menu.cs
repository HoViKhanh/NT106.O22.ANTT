using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_bai1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bai1 tmpForm = new Form_bai1();
            tmpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bai2 tmpForm = new Form_bai2();
            tmpForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bai3 tmpForm = new Form_bai3();
            tmpForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bai4 tmpForm = new Form_bai4();
            tmpForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bai5 tmpForm = new Form_bai5();
            tmpForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

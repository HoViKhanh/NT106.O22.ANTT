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
    public partial class Form_bai4 : Form
    {
        public Form_bai4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tmpForm = new Menu();
            tmpForm.Show();
        }
    }
}

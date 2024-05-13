using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab4_Bai01 tmpForm = new Lab4_Bai01();
            tmpForm.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab4_Bai02 tmpForm = new Lab4_Bai02();
            tmpForm.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab4_Bai03 tmpForm = new Lab4_Bai03();
            tmpForm.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Lab4_Bai04 tmpForm = new Lab4_Bai04();
            tmpForm.Show();
        }
    }
}

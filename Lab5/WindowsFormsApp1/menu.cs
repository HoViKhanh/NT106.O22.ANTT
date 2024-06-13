using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2 form = new _2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _3 form = new _3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b4 b4  = new b4();
            b4.Show();
        }
    }
}

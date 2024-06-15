using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Client : Form
    {
        Graphics graphics;
        Pen cursorPen;

        public Client()
        {
            InitializeComponent();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            color.Show();
        }

        private void board_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void board_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

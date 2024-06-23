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
    public partial class Form1 : Form
    {
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        public Form1()
        {
            InitializeComponent();
            graphics = board.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    cursorPen.Color = colorDialog.Color;
                }
            }
        }

        private void board_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            int cursorX = e.X;
            int cursorY = e.Y;
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics = board.CreateGraphics();
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void board_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            int cursorX = -1;
            int cursorY = -1;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int point = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point--;
            label2.Text = "Score" + point;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }

            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            Point spos = label1.Location;
            //Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            //label1.Left = fpos.X - label2.Width / 2;
            //label1.Top = fpos.Y - label2.Height / 2; ;
            label3.Text = $"{fpos.X},{fpos.Y}";

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                 && (fpos.Y < label1.Bottom)) ;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}

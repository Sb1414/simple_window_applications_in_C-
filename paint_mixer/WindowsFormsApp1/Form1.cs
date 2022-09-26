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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;
        private void panelBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelBack_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll_1(object sender, EventArgs e)
        {
            int red = trackBarRed.Value;
            int green = trackBarGreen.Value;
            int blue = trackBarBlue.Value;
            Color color = Color.FromArgb(red, green, blue);
            panelColor.BackColor = color;
        }

        private void trackBarGrey_Scroll(object sender, EventArgs e)
        {
            int grey = trackBarRed.Value;
            trackBarRed.Value = trackBarGreen.Value = trackBarBlue.Value = trackBarGrey.Value;
            Color color = Color.FromArgb(grey, grey, grey);
            panelColor.BackColor = color;
        }
    }
}

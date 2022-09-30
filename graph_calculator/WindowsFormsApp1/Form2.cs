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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panelBack_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black,3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i,(int)(Math.Cos((double)i/10)*100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);
            Point[] points = new Point[10000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Tan((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sqrt((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.White, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Cos((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.White, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.White, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Tan((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void buttonClear4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.White, 3f);
            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sqrt((double)i / 10) * 100 + 200));
            }
            graphics.DrawLines(pen, points);
        }
    }
}

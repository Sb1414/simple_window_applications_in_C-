using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Color color = Color.Red; // цвет графика
        int mode = 1; // режим отображения
        double a = 5, b = 100; // коэффициенты функции
        double p = -0.5, k = 2;

        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = mode;
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            txtK.Text = k.ToString();
            txtP.Text = p.ToString();
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


        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void buttonMaximized_Click(object sender, EventArgs e)
        {
            if (!flag)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;
        }

        private double MyFunc(double x, double a, double b, double k, double p)
        {
            double res;
            if (x == 0)
            {
                res = 0;
            } else
            {
                res = a * Math.Pow(x, -p) * Math.Sin(k * x + b);
            }
            return res;
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            this.chart1.Series[0].Points.Clear();
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            k = Convert.ToDouble(txtK.Text);
            p = Convert.ToDouble(txtP.Text);
            double dx = 5, y; // шаг расчета функции
            double x0 = 0.0, xn = chart1.Width; // интервал изменения х
            double i = x0;
            while (i <= xn)
            {
                chart1.Series[0].Color = color;
                y = a * Math.Pow(i, -p) * Math.Sin(k * i + b);
                this.chart1.Series[0].Points.AddXY(i, y);
                i += dx;
            }
        }

        /*private void MathGraph()
        {
            const double PI = Math.PI;
            double shag = 0.1;
            double mashtab = 30;
            int fillHeight = 100;
            int fillWidth = 500;
            int otstup = 5;

            Graphics e = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            e.FillRectangle(brush, new Rectangle(otstup, otstup, fillWidth, fillHeight));
            e.FillRectangle(brush, new Rectangle(otstup, 2 * otstup + fillHeight, fillWidth, fillHeight));

            int n = Convert.ToInt32(4 * PI / shag);
            Point[] pointGr = new Point[n];
            int p = 0;
            for (double i = 0; i < 4*PI; i+=shag)
            {
                pointGr[p] = new Point(Convert.ToInt32(i*mashtab+otstup), Convert.ToInt32((a * Math.Pow(i, -p) * Math.Sin(k * i + b))*mashtab+(fillHeight/2)+otstup));
                p++;
            }
            Pen pen = new Pen(Color.Black);
            e.DrawCurve(pen, pointGr);

        }*/

        private void buttonColorGraph_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                color = dlg.Color;
                panelGraph.Invalidate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            panelGraph.Invalidate();
        }

        /*
        private void deletedFun()
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            k = Convert.ToDouble(txtK.Text);
            p = Convert.ToDouble(txtP.Text);
         
            Graphics gPanel = panelGraph.CreateGraphics();
            Pen pe = new Pen(Color.Black, 1);

            Point y1 = new Point(panelGraph.Width / 2, 0);
            Point y2 = new Point(panelGraph.Width / 2, panelGraph.Height);
            gPanel.DrawLine(pe, y1, y2);

            Point x1 = new Point(0, panelGraph.Height / 2);
            Point x2 = new Point(panelGraph.Width, panelGraph.Height / 2);
            gPanel.DrawLine(pe, x1, x2);

            //центр
            Point center = new Point(panelGraph.Width / 2, panelGraph.Height / 2);

            //каждые 10, это одна условная единца, ну предположим см. Рисуем засечки. 

            // Brush br = new SolidBrush(Color.Black);
            //Pen pe2 = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.Black, 3);
            Point[] points = new Point[10000];
            //рисуем график
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)MyFunc(i, a, b, k, p));
                //double x = i * 0.1;//каждый умножаем на 1/10 чтобы на 10 получилась услованя еденица
                //double y = MyFunc(i, a, b, k, p);
                // double y = a * Math.Pow(x, -p) * Math.Sin(k * x + b);
                //переносим в центр
                //double xx = x + center.X;
                //double yy = y + center.Y;

                //Point x = new Point(i, (int)MyFunc(i, a, b, k, p));
                //Point y = new Point(i, (int)MyFunc(i, a, b, k, p));
                //gPanel.DrawLine(pe2, x, y);

                //gPanel.DrawLine(pe2, (float)x, (float)y, (float)x, (float)y);
                // gPanel.FillEllipse(br, (float)x, (float)y, 2, 2);//рисуем кружочками
            }
            gPanel.DrawLines(pen, points);
        }
        */
    }
}

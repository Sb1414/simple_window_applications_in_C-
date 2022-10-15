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
        public Form1()
        {
            InitializeComponent();
        }

        public string patch;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxC.Text == "")
            {
                MessageBox.Show("Заполните поля коэффициентов!", "Error", MessageBoxButtons.OK);
            }
            else if (Regex.IsMatch(textBoxA.Text, "^[0-9]+$") && Regex.IsMatch(textBoxB.Text, "^[0-9]+$") && Regex.IsMatch(textBoxC.Text, "^[0-9]+$"))
            {
                // MessageBox.Show("ok", "Error", MessageBoxButtons.OK);
                double a, b, c;
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
                checkArgs(a, b, c);
            } else
            {
                MessageBox.Show("Некорректный ввод, можно вводить только числа!", "Error", MessageBoxButtons.OK);
            }
        }

        public double checkArgs(double a, double b, double c)
        {
            double res = 0;
            if (a == 0 && b != 0)
            {
                labelinfo.Text = "A = 0, это линейное уравнение!";
                labelinfo.ForeColor = Color.Red;
                res = -c/b;
                label6.Visible = false;
                label7.Visible = false;
                label11.Text = "x = " + res;
                label12.Text = "не существует";
            }
            else if (a == 0 && b == 0)
            {
                labelinfo.Text = "A = 0 и B = 0, решений нет!";
                labelinfo.ForeColor = Color.Red;
                label6.Visible = false;
                label7.Visible = false;
                label11.Text = "не существует";
                label12.Text = "не существует";
            } else
            {
                discriminant(a, b, c);
            }
            return res;
        }

        public void discriminant(double a, double b, double c)
        {
            label6.Visible = true;
            label7.Visible = true;
            double d = b * b - 4 * a * c, x1, x2;
            if (d < 0)
            {
                labelinfo.Text = "Дискриминант меньше нуля";
                labelinfo.ForeColor = Color.Red;
                label7.Text = "D = " + d.ToString();
                label11.Text = "корней нет";
                label12.Text = "корней нет";
            }
            else if (d == 0)
            {
                labelinfo.Text = "Дискриминант равен нулю";
                labelinfo.ForeColor = Color.Gray;
                x1 = -b / 2 * a;
                label7.Text = "D = 0";
                label11.Text = x1.ToString();
                label12.Text = "-";
            }
            else
            {
                labelinfo.Text = "Дискриминант больше нуля";
                labelinfo.ForeColor = Color.Gray;
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                label7.Text = "D = " + d.ToString();
                label11.Text = x1.ToString();
                label12.Text = x2.ToString();
            }
        }
    }
}

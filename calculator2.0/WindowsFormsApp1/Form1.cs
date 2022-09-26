using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string action;
        public string numFirst;
        public bool numSecond;
        public Form1()
        {
            numSecond = false;
            InitializeComponent();
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

        /* для раскраски границ табла */
        private void panelBack_Paint(object sender, PaintEventArgs e)
        {
           // e.Graphics.DrawRectangle(new Pen(Color.Black),
           // new Rectangle(tablo.Location.X - 1, tablo.Location.Y - 1, tablo.Width + 1, tablo.Height + 1));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else 
                tablo.Text += B.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!tablo.Text.Contains("."))
                tablo.Text += ",";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numSecond)
            {
                numSecond = false;
                tablo.Text = "0";
            }
            Button B = (Button)sender;
            if (tablo.Text == "0")
                tablo.Text = B.Text;
            else
                tablo.Text += B.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            tablo.Text = "0";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            numFirst = tablo.Text;
            numSecond = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            numFirst = tablo.Text;
            numSecond = true;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            numFirst = tablo.Text;
            numSecond = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            numFirst = tablo.Text;
            numSecond = true;
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            double acN1, acN2, res = 0;
            acN1 = Convert.ToDouble(numFirst);
            acN2 = Convert.ToDouble(tablo.Text);
            if (action == "+")
            {
                res = acN1 + acN2;
            }
            if (action == "-")
            {
                res = acN1 - acN2;
            }
            if (action == "x")
            {
                res = acN1 * acN2;
            }
            if (action == "÷")
            {
                res = acN1 / acN2;
            }
            if (action == "%")
            {
                res = acN1 * acN2 / 100;
            }
            action = "=";
            numSecond = true;
            tablo.Text = res.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Pow(disp, 2);
            tablo.Text = res.ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = - disp;
            tablo.Text = res.ToString();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            tablo.Text = tablo.Text.Substring(0, tablo.Text.Length - 1);
            if (tablo.Text == "")
                tablo.Text = "0";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Sqrt(disp);
            tablo.Text = res.ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Sin(disp);
            tablo.Text = res.ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Tan(disp);
            tablo.Text = res.ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Cos(disp);
            tablo.Text = res.ToString();
        }

        private void buttonCatan_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = Math.Cos(disp) / Math.Sin(disp);
            tablo.Text = res.ToString();
        }

        private void buttonDelX_Click(object sender, EventArgs e)
        {
            double disp, res;
            disp = Convert.ToDouble(tablo.Text);
            res = 1 / disp;
            tablo.Text = res.ToString();
        }
    }
}

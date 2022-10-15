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
            textBox1.Text = "от";
            textBox2.Text = "до";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
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
            if (richTextBox1.Text != "" || richTextBox2.Text != "")
            {
                if (MessageBox.Show("Остались несохраненные данные! Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
            }
            else
                this.Close();
        }


        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename);
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = saveFileDialog1.FileName;
                richTextBox2.SaveFile(filename);
            }
        }

        private void ToolStripMenuItemOpen1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename);
            }
        }

        private void ToolStripMenuItemOpen2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = openFileDialog1.FileName;
                richTextBox2.LoadFile(filename);
            }
        }

        private void mCodirovat_Click(object sender, EventArgs e)
        {
            label1.Text = "Диапазон изменения кода символов";
            Random rand = new Random();
            if (textBox1.Text != "" & textBox2.Text != "" & textBox1.Text != "от" & textBox2.Text != "до")
            {
                int one = Convert.ToInt32(textBox1.Text);
                int two = Convert.ToInt32(textBox2.Text);
                int num = rand.Next(one, two);
                if (one < 32 || two > 255)
                {
                    MessageBox.Show("Вы ввели число меньше 32 или больше 225");
                }
                else
                {
                    int count = richTextBox1.TextLength;
                    richTextBox2.Clear();
                    if (richTextBox1.Text == "")
                    {
                        MessageBox.Show("Поле исходного текста путое!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            char ch = richTextBox1.Text[i];
                            ch -= Convert.ToChar(num);
                            richTextBox2.Text += (ch).ToString();
                        }
                        label1.Text = "изменено на " + num + " символов";

                    }
                }
            } else
            {
                MessageBox.Show("Поле значений пусто!", "Warning", MessageBoxButtons.OK);
            }


        }

        private void mDecoder_Click(object sender, EventArgs e)
        {
            label1.Text = "Диапазон изменения кода символов";
            Random rand = new Random();
            int one = Convert.ToInt32(textBox1.Text);
            int two = Convert.ToInt32(textBox2.Text);
            int num = rand.Next(one, two);
            if (one < 32 || two > 255)
            {
                MessageBox.Show("Вы ввели число меньше 32 или больше 225");
            }
            else
            {
                int count = richTextBox2.TextLength;
                richTextBox2.Clear();
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Поле исходного текста путое!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        char ch = richTextBox1.Text[i];
                        ch -= Convert.ToChar(num);
                        richTextBox2.Text += (ch).ToString();
                    }
                    label1.Text = "изменено на " + num + " символов";
                }
            }
        }

        private void mRemove_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" || richTextBox2.Text != "")
            {
                if (MessageBox.Show("Остались несохраненные данные! Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "от")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "от";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "до")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "до";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}

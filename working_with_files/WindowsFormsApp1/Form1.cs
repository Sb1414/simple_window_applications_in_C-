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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string Rs { get; set; }
        public Form1()
        {
            InitializeComponent();
            textBoxStudent.Text = "enter text";
            textBoxStudent.ForeColor = Color.Gray;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "")
            {
                MessageBox.Show("Enter text, please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (textBoxStudent.Text == "enter text")
            {
                MessageBox.Show("Enter text, please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add(textBoxStudent.Text);
                textBoxStudent.Text = "";
            }
        }

        private void textBoxStudent_Enter(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "enter text")
            {
                textBoxStudent.Text = "";
                textBoxStudent.ForeColor = Color.Black;
            }
        }

        private void textBoxStudent_Leave(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "")
            {
                textBoxStudent.Text = "enter text";
                textBoxStudent.ForeColor = Color.Gray;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Sorted = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Sorted = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllLines(filename, listBox1.Items.Cast<string>());
            // Rs ="test.txt";
            // save();
            MessageBox.Show("Файл 'test.txt' успешно сохранен");
        }

        public void save()
        {
            StreamWriter SaveFile = new StreamWriter(Rs);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            System.IO.File.WriteAllLines(filename, listBox1.Items.Cast<string>());

            // open();
        }

        public void open()
        {
            Rs = "test.txt";
            StreamReader LoadFile = new StreamReader(Rs);
            while (!LoadFile.EndOfStream)
            {
                listBox1.Items.Add(LoadFile.ReadLine());
            }

            LoadFile.Close();
        }
    }
}

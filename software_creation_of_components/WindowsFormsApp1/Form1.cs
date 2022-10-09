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
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Text = "enter a number";
            textBoxInput.ForeColor = Color.Gray;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;
            this.Padding = new Padding(0, 0, 0, 20);
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private List<TextBox> inputTextBoxes;
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            string box = textBoxInput.Text;
            if (box == "enter a number")
            {
                MessageBox.Show("Enter a number, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(box, out num))
            {
                if (num < 1 | num > 20)
                {
                    MessageBox.Show("Eenter a number from 1 to 20", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    int inputNumber = Int32.Parse(textBoxInput.Text);
                    inputTextBoxes = new List<TextBox>();
                    for (int i = 1; i <= inputNumber; i++)
                    {
                        System.Windows.Forms.Label labelInput = new System.Windows.Forms.Label();
                        TextBox textBoxNewInput = new TextBox();
                        labelInput.Text = "Input " + i;
                        labelInput.Location = new Point(30, textBoxInput.Bottom + (i * 30));
                        labelInput.AutoSize = true;

                        textBoxNewInput.Location = new Point(labelInput.Width, labelInput.Top - 3);
                        inputTextBoxes.Add(textBoxNewInput);
                        this.Controls.Add(labelInput);
                        this.Controls.Add(textBoxNewInput);
                    }
                    Button buttonAdd = new Button();
                    buttonAdd.Text = "Add";
                    buttonAdd.Location = new Point(this.Width / 2 - buttonAdd.Width / 2, inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);
                    buttonAdd.Click += new EventHandler(buttonAdd_Click);
                    buttonAdd.BackColor = Color.FromArgb(34, 128, 87);
                    buttonAdd.FlatStyle = FlatStyle.Flat;
                    buttonAdd.FlatAppearance.BorderSize = 0;
                    this.Controls.Add(buttonAdd);
                    this.CenterToScreen();

                    buttonRemove.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Only numbers, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (TextBox textBoxNewInput in inputTextBoxes)
            {
                if (textBoxNewInput.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in all the text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    double num = 0.0;
                    string box = textBoxNewInput.Text;
                    if (double.TryParse(box, out num))
                    {
                        sum += num;
                    }
                }
            }
            MessageBox.Show("The Sum is " + sum);
        }

        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "enter a number")
            {
                textBoxInput.Text = "";
                textBoxInput.ForeColor = Color.Black;
            }
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                textBoxInput.Text = "enter a number";
                textBoxInput.ForeColor = Color.Gray;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBoxNewInput in inputTextBoxes)
            {
                this.Controls.Remove(textBoxNewInput);
                // this.Controls.Remove(labelInput);
            }
        }
    }
}

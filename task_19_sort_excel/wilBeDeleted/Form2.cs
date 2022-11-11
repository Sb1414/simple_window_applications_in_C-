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

namespace wilBeDeleted
{
    public partial class Form2 : Form
    {
        private bool flag = false;
        FormPass form1;
        public Form2(FormPass owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        Point lastPoint;
        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Возможно остались несохраненные изменения, сохранить?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CreateLines();
                this.Close();
            } else
            {
                this.Close();
            }
        }

        private void buttonMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximiz_Click(object sender, EventArgs e)
        {
            if (!flag)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CreateLines();
            this.Hide();
        }

        public void CreateLines()
        {
            if (textBoxAutor.Text != "" && textBoxName.Text != "")
            {
                int ind = form1.dataGridView1.CurrentRow.Index;
                if (textBoxAutor.Text != "" | textBoxAutor.Text != null)
                {
                    form1.dataGridView1.Rows[ind].Cells[0].Value = textBoxAutor.Text;
                }

                form1.dataGridView1.Rows[ind].Cells[1].Value = comboBoxType.Text;
                form1.dataGridView1.Rows[ind].Cells[2].Value = dateTimePickerDate.Text;
                form1.dataGridView1.Rows[ind].Cells[3].Value = numericUpDownYear.Value;
                form1.dataGridView1.Rows[ind].Cells[4].Value = numericUpDownCost.Text;

                if (textBoxName.Text != "" | textBoxName.Text != null)
                {
                    form1.dataGridView1.Rows[ind].Cells[5].Value = textBoxName.Text;
                }

                form1.dataGridView1.Rows[ind].Cells[6].Value = numericUpDownCount.Value;
            }
            else
            {
                MessageBox.Show("Ничего не введено!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

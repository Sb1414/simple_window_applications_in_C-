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
    public partial class FormPass : Form
    {
        private bool flag = false;
        Form2 form2;
        public FormPass()
        {
            InitializeComponent();
            toolStripTextBox1.Text = "Поиск";
            toolStripTextBox1.ForeColor = Color.Gray;
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
            this.Close();
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

        private void mOpen_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog1.FileName;
                    StreamReader a = new StreamReader(filename);
                    string line;
                    int count = 0, pos = 1;
                    while ((line = a.ReadLine()) != null)
                    {
                        count++;
                    }
                    dataGridView1.RowCount = count;
                    StreamReader str = new StreamReader(filename);
                    string[] res;
                    res = str.ReadToEnd().Split(' ', '\n');
                    // string first = str.ReadLine();
                    StreamReader a1 = new StreamReader(filename);
                    string line1 = a1.ReadLine();
                    string first = line1.Split()[0];

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                dataGridView1[0, 0].Value = first;
                            }
                            else
                            {
                                dataGridView1[j, i].Value = res[pos];
                                while (res[pos] == " ")
                                {
                                    pos++;
                                }

                                pos++;
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            ResetBColor();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                sw.Write(dataGridView1.Rows[i].Cells[j].Value);
                                if (j < dataGridView1.ColumnCount - 1) sw.Write(" ");
                            }
                            sw.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

        }

        private void mAddStr_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int ind = dataGridView1.CurrentRow.Index + 1;
                    dataGridView1.Rows.Insert(ind);
                }
                else
                {
                    throw new Exception("Не указано куда нужно добавить строку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void nDeleteStr_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else
                {
                    throw new Exception("Не указано какую строку нужно удалить!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void nRemoveStr_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (dataGridView1.CurrentRow != null)
                {   
                    new Form2(this).Show();

                }
                else
                {
                    throw new Exception("Не какую строку нужно очистить!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ResetBColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void mSearchSurname_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (toolStripTextBox1.Text != "Поиск" && toolStripTextBox1.Text != "")
                {
                    int c = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        if (dataGridView1.Rows[i].Cells["Column1"].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells["Column1"].Value.ToString().Contains(toolStripTextBox1.Text))
                            {
                                dataGridView1.Rows[i].Cells["Column1"].Style.BackColor = Color.Aqua;
                                c++;
                            }
                        }
                    }
                    if (c == 0)
                    {
                        MessageBox.Show("Фамилия не найдена", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string res = "Фамилия появилась " + c.ToString() + " раз";
                        MessageBox.Show(res, "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new Exception("Ничего не введено в поиск!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "Поиск")
            {
                toolStripTextBox1.Text = "";
                toolStripTextBox1.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                toolStripTextBox1.Text = "Поиск";
                toolStripTextBox1.ForeColor = Color.Gray;
            }
        }

        private void mSearchName_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (toolStripTextBox1.Text != "Поиск" && toolStripTextBox1.Text != "")
                {

                    int c = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        if (dataGridView1.Rows[i].Cells["Column2"].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells["Column2"].Value.ToString().Contains(toolStripTextBox1.Text))
                            {
                                dataGridView1.Rows[i].Cells["Column2"].Style.BackColor = Color.Aqua;
                                c++;
                            }
                        }
                    }
                    if (c == 0)
                    {
                        MessageBox.Show("Название не найдено", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string res = "Название появилось " + c.ToString() + " раз";
                        MessageBox.Show(res, "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new Exception("Ничего не введено в поиск!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mGive_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    int data;
                    if (dataGridView1.Rows[index].Cells["Column3"].Value != null)
                    {
                        data = int.Parse(dataGridView1.Rows[index].Cells["Column3"].Value.ToString());
                        if (data < 1)
                        {
                            throw new Exception("Книги закончились!");
                        }
                        else
                        {
                            dataGridView1.Rows[index].Cells["Column3"].Value = data - 1;
                        }
                    }
                }
                else
                {
                    throw new Exception("Ничего не выбрано!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void mReturn_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    int data;
                    if (dataGridView1.Rows[index].Cells["Column3"].Value != null)
                    {
                        data = int.Parse(dataGridView1.Rows[index].Cells["Column3"].Value.ToString());
                        dataGridView1.Rows[index].Cells["Column3"].Value = data + 1;
                    }
                }
                else
                {
                    throw new Exception("Ничего не выбрано!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void mSortAutor_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column1"], ListSortDirection.Ascending);
        }

        private void mSortIzd_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column4"], ListSortDirection.Ascending);
        }

        private void mSortDate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column5"].ValueType = typeof(DateTime);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column5"], ListSortDirection.Ascending);
        }

        private void mSortName_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column2"], ListSortDirection.Ascending);
        }

        private void mSortCount_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column3"], ListSortDirection.Ascending);
        }
    }
}

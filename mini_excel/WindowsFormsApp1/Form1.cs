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
using ExcelDataReader;
using OfficeOpenXml;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //private string fileName = string.Empty;

        //private DataTableCollection tableCollection = null;

        //private double[,] excelTable;
        //private int totalRows = 0;
        //private int totalColumns = 0;

        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            toolStripTextBox1.Text = "Поиск";
            toolStripTextBox1.ForeColor = Color.Gray;
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
            if (MessageBox.Show("Возможно остались несохраненные изменения, выйти?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void mOpen_Click(object sender, EventArgs e)
        {
            ResetBColor();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    /*
                    fileName = openFileDialog1.FileName;
                    Text = fileName;
                    OpenExcelFile(fileName);
                    */
                    /*
                    ExcelPackage excelFile = new ExcelPackage(new FileInfo(openFileDialog1.FileName));
                    ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1];

                    totalRows = worksheet.Dimension.End.Row;
                    totalColumns = worksheet.Dimension.End.Column;

                    excelTable = new double[totalRows, totalColumns];
                    */

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
                            } else
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
                    /*
                    string filename = openFileDialog1.FileName;

                    StreamReader rd = new StreamReader(filename);
                    DataSet ds = new DataSet();
                    string header = rd.ReadLine();
                    string[] col = System.Text.RegularExpressions.Regex.Split(header, " ");
                    for (int i = 0; i < col.Length; i++)
                    {
                        ds.Tables[i].Columns.Add(col[i]);

                    }
                    string row = rd.ReadLine();
                    while (row != null)
                    {
                        string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, " ");
                        ds.Tables[0].Rows.Add(rvalue);
                        row = rd.ReadLine();
                    }
                    dataGridView1.DataSource = ds.Tables[0];
                    */
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
                    dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index);
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
                    int ind = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows[ind].Cells[0].Value = "";
                    dataGridView1.Rows[ind].Cells[1].Value = "";
                    dataGridView1.Rows[ind].Cells[2].Value = "";

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
                } else
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
                        } else
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
    }
}

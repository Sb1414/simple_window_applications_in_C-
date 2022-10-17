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

        private void mOpen_Click(object sender, EventArgs e)
        {
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


        /*
        private void OpenExcelFile(string patch)
        {
            FileStream stream = File.Open(patch, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            }) ;

            tableCollection = db.Tables;
            toolStripComboBox1.Items.Clear();
            foreach(DataTable table in tableCollection)
            {
                toolStripComboBox1.Items.Add(table.TableName);
            }
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[Convert.ToString(toolStripComboBox1.SelectedIndex)];
            dataGridView1.DataSource = table;
        }
        */
    }
}

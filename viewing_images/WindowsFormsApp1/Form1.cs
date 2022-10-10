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

        private Boolean FillListBox(string patch)
        {
            DirectoryInfo directory = new DirectoryInfo(patch);
            FileInfo[] files = directory.GetFiles("*.jpg");
            listBox1.Items.Clear();
            foreach (FileInfo Files in files)
            {
                listBox1.Items.Add(Files.Name);
            }
            labelPatch.Text = patch;
            if (files.Length == 0) return false;
            else
            {
                listBox1.SelectedIndex = 0;
                return true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(patch + "\\" + listBox1.SelectedItem.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Выберите папку";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                patch = dialog.SelectedPath;
                labelPatch.Text = patch;
                if (!FillListBox(dialog.SelectedPath))
                    pictureBox1.Image = null;
            }
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

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
        private bool flag = false;
        Image buttImage;
        bool changed = false;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void mOpen_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename);
            }
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename);
            }
        }

        private void mCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void mCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void mPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void mFont_Click(object sender, EventArgs e)
        {
            FontDialog fn = new FontDialog();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fn.Font;
            }
        }

        private void mForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog fn = new ColorDialog();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fn.Color;
            }
        }

        private void mColor_Click(object sender, EventArgs e)
        {
            ColorDialog fn = new ColorDialog();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fn.Color;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            InstalledFontCollection inf = new InstalledFontCollection();
            foreach(FontFamily font in inf.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(toolStripComboBox1.Text, richTextBox1.Font.Size);
        }

        private void buttonMaximized_Click(object sender, EventArgs e)
        {
            if (!flag)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttImage = this.toolStripButton1.Image;
        }

        private void mDark_Click(object sender, EventArgs e)
        {
            if (!changed)
            {
                toolStripButton1.Image = Properties.Resources.icons8_символ_луны_20;
                labellogo.ForeColor = Color.FromArgb(125, 177, 143);
                panel1.BackColor = Color.FromArgb(4, 62, 44);
                panel1.ForeColor = Color.FromArgb(125, 177, 143);
                panelBack.BackColor = Color.FromArgb(4, 62, 44);
                buttonClose.BackColor = Color.FromArgb(4, 69, 44);
                buttonMaximized.BackColor = Color.FromArgb(4, 69, 44);
                buttonMinimized.BackColor = Color.FromArgb(4, 69, 44);
                menuStrip1.BackColor = Color.FromArgb(4, 69, 44);
                menuStrip1.ForeColor = Color.FromArgb(125, 177, 143);
                toolStrip1.BackColor = Color.FromArgb(4, 69, 44);
                toolStrip1.ForeColor = Color.FromArgb(125, 177, 143);
                toolStripComboBox1.BackColor = Color.FromArgb(4, 69, 44);
                toolStripComboBox1.ForeColor = Color.FromArgb(125, 177, 143);
                richTextBox1.BackColor = Color.FromArgb(49, 113, 90);
                richTextBox1.ForeColor = Color.FromArgb(125, 177, 143);
                panel1.BackColor = Color.FromArgb(160, 220, 189);
            }
            else
            {
                toolStripButton10.Image = Properties.Resources.icons8_солнце_24;
                labellogo.ForeColor = Color.Black;
                panel1.BackColor = Color.FromArgb(121, 186, 158);
                panel1.ForeColor = Color.Black;
                panelBack.BackColor = Color.FromArgb(121, 186, 158);
                buttonClose.BackColor = Color.FromArgb(108, 175, 146);
                buttonMaximized.BackColor = Color.FromArgb(108, 175, 146);
                buttonMinimized.BackColor = Color.FromArgb(108, 175, 146);
                menuStrip1.BackColor = Color.FromArgb(121, 186, 158);
                menuStrip1.ForeColor = Color.Black;
                toolStrip1.BackColor = Color.FromArgb(121, 186, 158);
                toolStrip1.ForeColor = Color.Black;
                toolStripComboBox1.BackColor = Color.FromArgb(121, 186, 158);
                toolStripComboBox1.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.FromArgb(169, 228, 202);
                richTextBox1.ForeColor = Color.Black;
                panel1.BackColor = Color.FromArgb(169, 228, 202);
            }
            changed = !changed;
        }

        private void mLight_Click(object sender, EventArgs e)
        {

        }
    }
}

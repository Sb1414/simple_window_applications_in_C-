namespace wilBeDeleted
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonMaximiz = new System.Windows.Forms.Button();
            this.buttonMinimiz = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBorder.BackgroundImage = global::wilBeDeleted.Properties.Resources.background;
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.label1);
            this.panelBorder.Controls.Add(this.labelPas);
            this.panelBorder.Controls.Add(this.panelUp);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(828, 524);
            this.panelBorder.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::wilBeDeleted.Properties.Resources.Без_имени_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(465, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 319);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 144);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выполнила студентка группы пи-112 Калкаманова сабина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPas
            // 
            this.labelPas.BackColor = System.Drawing.Color.Transparent;
            this.labelPas.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPas.Location = new System.Drawing.Point(45, 55);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(242, 242);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Демо-программа для показа основных возможностей компонента DataGridView";
            this.labelPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelUp.Controls.Add(this.buttonMaximiz);
            this.panelUp.Controls.Add(this.buttonMinimiz);
            this.panelUp.Controls.Add(this.buttonClose);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(828, 28);
            this.panelUp.TabIndex = 0;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            // 
            // buttonMaximiz
            // 
            this.buttonMaximiz.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximiz.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_macos_полный_экран_20__1_;
            this.buttonMaximiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMaximiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximiz.FlatAppearance.BorderSize = 0;
            this.buttonMaximiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximiz.Location = new System.Drawing.Point(78, 5);
            this.buttonMaximiz.Name = "buttonMaximiz";
            this.buttonMaximiz.Size = new System.Drawing.Size(28, 31);
            this.buttonMaximiz.TabIndex = 3;
            this.buttonMaximiz.UseVisualStyleBackColor = false;
            this.buttonMaximiz.Click += new System.EventHandler(this.buttonMaximiz_Click);
            // 
            // buttonMinimiz
            // 
            this.buttonMinimiz.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimiz.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_macos_свернуть_20__1_;
            this.buttonMinimiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinimiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimiz.FlatAppearance.BorderSize = 0;
            this.buttonMinimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimiz.Location = new System.Drawing.Point(41, 5);
            this.buttonMinimiz.Name = "buttonMinimiz";
            this.buttonMinimiz.Size = new System.Drawing.Size(27, 25);
            this.buttonMinimiz.TabIndex = 2;
            this.buttonMinimiz.UseVisualStyleBackColor = false;
            this.buttonMinimiz.Click += new System.EventHandler(this.buttonMinimiz_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_macos_закрыть_20__1_;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(7, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 31);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaximiz;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonMinimiz;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
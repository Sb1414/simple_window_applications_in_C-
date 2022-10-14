namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBack = new System.Windows.Forms.Panel();
            this.labellogo = new System.Windows.Forms.Label();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelPatch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRandomNums = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFirst = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxSecond = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mObrabotka = new System.Windows.Forms.ToolStripMenuItem();
            this.mCodirovat = new System.Windows.Forms.ToolStripMenuItem();
            this.mDecoder = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelBack.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRandomNums.SuspendLayout();
            this.groupBoxFirst.SuspendLayout();
            this.groupBoxSecond.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(186)))), ((int)(((byte)(158)))));
            this.panelBack.Controls.Add(this.labellogo);
            this.panelBack.Controls.Add(this.buttonMinimized);
            this.panelBack.Controls.Add(this.buttonClose);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(511, 35);
            this.panelBack.TabIndex = 0;
            this.panelBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
            // 
            // labellogo
            // 
            this.labellogo.AutoSize = true;
            this.labellogo.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labellogo.Location = new System.Drawing.Point(12, 5);
            this.labellogo.Name = "labellogo";
            this.labellogo.Size = new System.Drawing.Size(296, 24);
            this.labellogo.TabIndex = 1;
            this.labellogo.Text = "Кодирование / декодирование";
            this.labellogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
            this.labellogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.buttonMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimized.FlatAppearance.BorderSize = 0;
            this.buttonMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimized.Location = new System.Drawing.Point(437, 1);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(34, 33);
            this.buttonMinimized.TabIndex = 0;
            this.buttonMinimized.Text = "—";
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(477, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelPatch
            // 
            this.labelPatch.AutoSize = true;
            this.labelPatch.Font = new System.Drawing.Font("Arial Black", 9F);
            this.labelPatch.Location = new System.Drawing.Point(13, 38);
            this.labelPatch.Name = "labelPatch";
            this.labelPatch.Size = new System.Drawing.Size(0, 22);
            this.labelPatch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelRandomNums);
            this.panel1.Controls.Add(this.groupBoxFirst);
            this.panel1.Controls.Add(this.groupBoxSecond);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 441);
            this.panel1.TabIndex = 3;
            // 
            // panelRandomNums
            // 
            this.panelRandomNums.Controls.Add(this.textBox2);
            this.panelRandomNums.Controls.Add(this.textBox1);
            this.panelRandomNums.Controls.Add(this.label1);
            this.panelRandomNums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRandomNums.Location = new System.Drawing.Point(0, 204);
            this.panelRandomNums.Name = "panelRandomNums";
            this.panelRandomNums.Size = new System.Drawing.Size(511, 51);
            this.panelRandomNums.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(417, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(340, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диапазон изменения кода символов";
            // 
            // groupBoxFirst
            // 
            this.groupBoxFirst.Controls.Add(this.richTextBox1);
            this.groupBoxFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFirst.Location = new System.Drawing.Point(0, 28);
            this.groupBoxFirst.Name = "groupBoxFirst";
            this.groupBoxFirst.Size = new System.Drawing.Size(511, 176);
            this.groupBoxFirst.TabIndex = 2;
            this.groupBoxFirst.TabStop = false;
            this.groupBoxFirst.Text = "Исходный текст";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(466, 139);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBoxSecond
            // 
            this.groupBoxSecond.Controls.Add(this.richTextBox2);
            this.groupBoxSecond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxSecond.Location = new System.Drawing.Point(0, 255);
            this.groupBoxSecond.Name = "groupBoxSecond";
            this.groupBoxSecond.Size = new System.Drawing.Size(511, 186);
            this.groupBoxSecond.TabIndex = 1;
            this.groupBoxSecond.TabStop = false;
            this.groupBoxSecond.Text = "Обработанный текст";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(22, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(466, 139);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mObrabotka,
            this.mExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpen,
            this.mSave});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(59, 24);
            this.mFile.Text = "Файл";
            // 
            // mOpen
            // 
            this.mOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen1,
            this.ToolStripMenuItemOpen2});
            this.mOpen.Name = "mOpen";
            this.mOpen.Size = new System.Drawing.Size(166, 26);
            this.mOpen.Text = "Открыть";
            // 
            // ToolStripMenuItemOpen1
            // 
            this.ToolStripMenuItemOpen1.Name = "ToolStripMenuItemOpen1";
            this.ToolStripMenuItemOpen1.Size = new System.Drawing.Size(237, 26);
            this.ToolStripMenuItemOpen1.Text = "Исходный текст";
            this.ToolStripMenuItemOpen1.Click += new System.EventHandler(this.ToolStripMenuItemOpen1_Click);
            // 
            // ToolStripMenuItemOpen2
            // 
            this.ToolStripMenuItemOpen2.Name = "ToolStripMenuItemOpen2";
            this.ToolStripMenuItemOpen2.Size = new System.Drawing.Size(237, 26);
            this.ToolStripMenuItemOpen2.Text = "Обработанный текст";
            this.ToolStripMenuItemOpen2.Click += new System.EventHandler(this.ToolStripMenuItemOpen2_Click);
            // 
            // mSave
            // 
            this.mSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2});
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(166, 26);
            this.mSave.Text = "Сохранить";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.ToolStripMenuItem1.Text = "Исходный текст";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(237, 26);
            this.ToolStripMenuItem2.Text = "Обработанный текст";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // mObrabotka
            // 
            this.mObrabotka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCodirovat,
            this.mDecoder,
            this.mRemove});
            this.mObrabotka.Name = "mObrabotka";
            this.mObrabotka.Size = new System.Drawing.Size(99, 24);
            this.mObrabotka.Text = "Обработка";
            // 
            // mCodirovat
            // 
            this.mCodirovat.Name = "mCodirovat";
            this.mCodirovat.Size = new System.Drawing.Size(191, 26);
            this.mCodirovat.Text = "Кодировать";
            this.mCodirovat.Click += new System.EventHandler(this.mCodirovat_Click);
            // 
            // mDecoder
            // 
            this.mDecoder.Name = "mDecoder";
            this.mDecoder.Size = new System.Drawing.Size(191, 26);
            this.mDecoder.Text = "Декодировать";
            this.mDecoder.Click += new System.EventHandler(this.mDecoder_Click);
            // 
            // mRemove
            // 
            this.mRemove.Name = "mRemove";
            this.mRemove.Size = new System.Drawing.Size(191, 26);
            this.mRemove.Text = "Очистить";
            this.mRemove.Click += new System.EventHandler(this.mRemove_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(67, 24);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(228)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(511, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPatch);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRandomNums.ResumeLayout(false);
            this.panelRandomNums.PerformLayout();
            this.groupBoxFirst.ResumeLayout(false);
            this.groupBoxSecond.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labellogo;
        private System.Windows.Forms.Label labelPatch;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBoxFirst;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBoxSecond;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.ToolStripMenuItem mObrabotka;
        private System.Windows.Forms.ToolStripMenuItem mCodirovat;
        private System.Windows.Forms.ToolStripMenuItem mDecoder;
        private System.Windows.Forms.ToolStripMenuItem mRemove;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen2;
        private System.Windows.Forms.Panel panelRandomNums;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


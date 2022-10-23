namespace wilBeDeleted
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonMaximiz = new System.Windows.Forms.Button();
            this.buttonMinimiz = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBorder.BackgroundImage = global::wilBeDeleted.Properties.Resources.background;
            this.panelBorder.Controls.Add(this.buttonSave);
            this.panelBorder.Controls.Add(this.buttonCancel);
            this.panelBorder.Controls.Add(this.label7);
            this.panelBorder.Controls.Add(this.numericUpDownCost);
            this.panelBorder.Controls.Add(this.label6);
            this.panelBorder.Controls.Add(this.numericUpDownYear);
            this.panelBorder.Controls.Add(this.label5);
            this.panelBorder.Controls.Add(this.dateTimePickerDate);
            this.panelBorder.Controls.Add(this.label4);
            this.panelBorder.Controls.Add(this.comboBoxType);
            this.panelBorder.Controls.Add(this.label3);
            this.panelBorder.Controls.Add(this.numericUpDownCount);
            this.panelBorder.Controls.Add(this.label2);
            this.panelBorder.Controls.Add(this.textBoxName);
            this.panelBorder.Controls.Add(this.textBoxAutor);
            this.panelBorder.Controls.Add(this.label1);
            this.panelBorder.Controls.Add(this.panelUp);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(828, 524);
            this.panelBorder.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Thistle;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(193, 434);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 42);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Thistle;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(469, 434);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(168, 42);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Цена";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCost.Location = new System.Drawing.Point(346, 352);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCost.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(260, 36);
            this.numericUpDownCost.TabIndex = 13;
            this.numericUpDownCost.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Год издания";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownYear.Location = new System.Drawing.Point(346, 310);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(260, 36);
            this.numericUpDownYear.TabIndex = 11;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата выдачи/возврата";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(346, 268);
            this.dateTimePickerDate.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.dateTimePickerDate.MinDate = new System.DateTime(1980, 12, 25, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(260, 36);
            this.dateTimePickerDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(141, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип издания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Учебник",
            "Книга",
            "Методический материал",
            "Задачник",
            "Справочник"});
            this.comboBoxType.Location = new System.Drawing.Point(346, 226);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(260, 36);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.Tag = "";
            this.comboBoxType.Text = "Учебник";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(156, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(346, 184);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(260, 36);
            this.numericUpDownCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(346, 142);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 36);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAutor.Location = new System.Drawing.Point(346, 100);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(260, 36);
            this.textBoxAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonMaximiz;
        private System.Windows.Forms.Button buttonMinimiz;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxAutor;
        public System.Windows.Forms.NumericUpDown numericUpDownCost;
        public System.Windows.Forms.NumericUpDown numericUpDownYear;
        public System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.NumericUpDown numericUpDownCount;
    }
}
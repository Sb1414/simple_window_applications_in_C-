namespace wilBeDeleted
{
    partial class FormPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPass));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mOpen = new System.Windows.Forms.ToolStripButton();
            this.mSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mAddStr = new System.Windows.Forms.ToolStripButton();
            this.mDeleteStr = new System.Windows.Forms.ToolStripButton();
            this.mRemoveStr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mSearchSurname = new System.Windows.Forms.ToolStripButton();
            this.mSearchName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mGive = new System.Windows.Forms.ToolStripButton();
            this.mReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.mSortAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mSortIzd = new System.Windows.Forms.ToolStripMenuItem();
            this.mSortDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mSortName = new System.Windows.Forms.ToolStripMenuItem();
            this.mSortCount = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonMaximiz = new System.Windows.Forms.Button();
            this.buttonMinimiz = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.panelBorder.Controls.Add(this.panel1);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1095, 682);
            this.panelBorder.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = global::wilBeDeleted.Properties.Resources.background;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.panelUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 682);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 627);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Тип издания";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата выдачи/возврата";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Год издания";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Цена";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpen,
            this.mSave,
            this.toolStripSeparator1,
            this.mAddStr,
            this.mDeleteStr,
            this.mRemoveStr,
            this.toolStripSeparator2,
            this.mSearchSurname,
            this.mSearchName,
            this.toolStripSeparator3,
            this.mGive,
            this.mReturn,
            this.toolStripSeparator4,
            this.toolStripTextBox1,
            this.toolStripSeparator5,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mOpen
            // 
            this.mOpen.BackColor = System.Drawing.Color.Transparent;
            this.mOpen.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_woff_20;
            this.mOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mOpen.Image = ((System.Drawing.Image)(resources.GetObject("mOpen.Image")));
            this.mOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mOpen.Name = "mOpen";
            this.mOpen.Size = new System.Drawing.Size(29, 24);
            this.mOpen.Text = "Open";
            this.mOpen.Click += new System.EventHandler(this.mOpen_Click);
            // 
            // mSave
            // 
            this.mSave.BackColor = System.Drawing.Color.Transparent;
            this.mSave.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_сохранить_20;
            this.mSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mSave.Image = ((System.Drawing.Image)(resources.GetObject("mSave.Image")));
            this.mSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(29, 24);
            this.mSave.Text = "Save";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // mAddStr
            // 
            this.mAddStr.BackColor = System.Drawing.Color.Transparent;
            this.mAddStr.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_добавить_свойство_20;
            this.mAddStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mAddStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mAddStr.Image = ((System.Drawing.Image)(resources.GetObject("mAddStr.Image")));
            this.mAddStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mAddStr.Name = "mAddStr";
            this.mAddStr.Size = new System.Drawing.Size(29, 24);
            this.mAddStr.Text = "Add string";
            this.mAddStr.Click += new System.EventHandler(this.mAddStr_Click);
            // 
            // mDeleteStr
            // 
            this.mDeleteStr.BackColor = System.Drawing.Color.Transparent;
            this.mDeleteStr.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_мусор_20;
            this.mDeleteStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mDeleteStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mDeleteStr.Image = ((System.Drawing.Image)(resources.GetObject("mDeleteStr.Image")));
            this.mDeleteStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mDeleteStr.Name = "mDeleteStr";
            this.mDeleteStr.Size = new System.Drawing.Size(29, 24);
            this.mDeleteStr.Text = "delete";
            this.mDeleteStr.Click += new System.EventHandler(this.nDeleteStr_Click);
            // 
            // mRemoveStr
            // 
            this.mRemoveStr.BackColor = System.Drawing.Color.Transparent;
            this.mRemoveStr.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_добавить_20;
            this.mRemoveStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mRemoveStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mRemoveStr.Image = ((System.Drawing.Image)(resources.GetObject("mRemoveStr.Image")));
            this.mRemoveStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mRemoveStr.Name = "mRemoveStr";
            this.mRemoveStr.Size = new System.Drawing.Size(29, 24);
            this.mRemoveStr.Text = "Change the line";
            this.mRemoveStr.Click += new System.EventHandler(this.nRemoveStr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mSearchSurname
            // 
            this.mSearchSurname.BackColor = System.Drawing.Color.Transparent;
            this.mSearchSurname.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_поиск_20;
            this.mSearchSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mSearchSurname.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mSearchSurname.Image = ((System.Drawing.Image)(resources.GetObject("mSearchSurname.Image")));
            this.mSearchSurname.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSearchSurname.Name = "mSearchSurname";
            this.mSearchSurname.Size = new System.Drawing.Size(29, 24);
            this.mSearchSurname.Text = "Search surname";
            this.mSearchSurname.Click += new System.EventHandler(this.mSearchSurname_Click);
            // 
            // mSearchName
            // 
            this.mSearchName.BackColor = System.Drawing.Color.Transparent;
            this.mSearchName.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_поиск_20;
            this.mSearchName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mSearchName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mSearchName.Image = ((System.Drawing.Image)(resources.GetObject("mSearchName.Image")));
            this.mSearchName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mSearchName.Name = "mSearchName";
            this.mSearchName.Size = new System.Drawing.Size(29, 24);
            this.mSearchName.Text = "search name";
            this.mSearchName.Click += new System.EventHandler(this.mSearchName_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // mGive
            // 
            this.mGive.BackColor = System.Drawing.Color.Transparent;
            this.mGive.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_новая_копия_20;
            this.mGive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mGive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mGive.Image = global::wilBeDeleted.Properties.Resources.icons8_новая_копия_20;
            this.mGive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mGive.Name = "mGive";
            this.mGive.Size = new System.Drawing.Size(29, 24);
            this.mGive.Text = "give";
            this.mGive.Click += new System.EventHandler(this.mGive_Click);
            // 
            // mReturn
            // 
            this.mReturn.BackColor = System.Drawing.Color.Transparent;
            this.mReturn.BackgroundImage = global::wilBeDeleted.Properties.Resources.icons8_выбрать_строку_20;
            this.mReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.mReturn.Image = ((System.Drawing.Image)(resources.GetObject("mReturn.Image")));
            this.mReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mReturn.Name = "mReturn";
            this.mReturn.Size = new System.Drawing.Size(29, 24);
            this.mReturn.Text = "mReturn";
            this.mReturn.Click += new System.EventHandler(this.mReturn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Enter += new System.EventHandler(this.toolStripTextBox1_Enter);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSortAutor,
            this.mSortIzd,
            this.mSortDate,
            this.mSortName,
            this.mSortCount});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // mSortAutor
            // 
            this.mSortAutor.Name = "mSortAutor";
            this.mSortAutor.Size = new System.Drawing.Size(224, 26);
            this.mSortAutor.Text = "По автору";
            this.mSortAutor.Click += new System.EventHandler(this.mSortAutor_Click);
            // 
            // mSortIzd
            // 
            this.mSortIzd.Name = "mSortIzd";
            this.mSortIzd.Size = new System.Drawing.Size(224, 26);
            this.mSortIzd.Text = "По типу издания";
            this.mSortIzd.Click += new System.EventHandler(this.mSortIzd_Click);
            // 
            // mSortDate
            // 
            this.mSortDate.Name = "mSortDate";
            this.mSortDate.Size = new System.Drawing.Size(224, 26);
            this.mSortDate.Text = "По дате выдачи";
            this.mSortDate.Click += new System.EventHandler(this.mSortDate_Click);
            // 
            // mSortName
            // 
            this.mSortName.Name = "mSortName";
            this.mSortName.Size = new System.Drawing.Size(224, 26);
            this.mSortName.Text = "По названию";
            this.mSortName.Click += new System.EventHandler(this.mSortName_Click);
            // 
            // mSortCount
            // 
            this.mSortCount.Name = "mSortCount";
            this.mSortCount.Size = new System.Drawing.Size(224, 26);
            this.mSortCount.Text = "По количеству";
            this.mSortCount.Click += new System.EventHandler(this.mSortCount_Click);
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
            this.panelUp.Size = new System.Drawing.Size(1095, 28);
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
            this.buttonMaximiz.Location = new System.Drawing.Point(74, 3);
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
            this.buttonMinimiz.Location = new System.Drawing.Point(37, 3);
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
            this.buttonClose.Location = new System.Drawing.Point(3, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 31);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 682);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBorder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mOpen;
        private System.Windows.Forms.ToolStripButton mSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mAddStr;
        private System.Windows.Forms.ToolStripButton mDeleteStr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mSearchSurname;
        private System.Windows.Forms.ToolStripButton mSearchName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mGive;
        private System.Windows.Forms.ToolStripButton mReturn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonMaximiz;
        private System.Windows.Forms.Button buttonMinimiz;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ToolStripButton mRemoveStr;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem mSortAutor;
        private System.Windows.Forms.ToolStripMenuItem mSortIzd;
        private System.Windows.Forms.ToolStripMenuItem mSortDate;
        private System.Windows.Forms.ToolStripMenuItem mSortName;
        private System.Windows.Forms.ToolStripMenuItem mSortCount;
    }
}


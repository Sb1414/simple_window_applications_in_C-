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
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.trackBarGrey = new System.Windows.Forms.TrackBar();
            this.labelGrey = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(186)))), ((int)(((byte)(158)))));
            this.panelBack.Controls.Add(this.labelGrey);
            this.panelBack.Controls.Add(this.trackBarGrey);
            this.panelBack.Controls.Add(this.panelColor);
            this.panelBack.Controls.Add(this.labelBlue);
            this.panelBack.Controls.Add(this.labelGreen);
            this.panelBack.Controls.Add(this.labelRed);
            this.panelBack.Controls.Add(this.trackBarBlue);
            this.panelBack.Controls.Add(this.trackBarGreen);
            this.panelBack.Controls.Add(this.trackBarRed);
            this.panelBack.Controls.Add(this.buttonClose);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(643, 586);
            this.panelBack.TabIndex = 0;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
            this.panelBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(68, 266);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(498, 272);
            this.panelColor.TabIndex = 7;
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlue.Location = new System.Drawing.Point(50, 143);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(71, 28);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "BLUE";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreen.Location = new System.Drawing.Point(31, 92);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(90, 28);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "GREEN";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRed.Location = new System.Drawing.Point(63, 42);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(58, 28);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "RED";
            this.labelRed.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBlue.Location = new System.Drawing.Point(127, 143);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(439, 56);
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.TickFrequency = 15;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarRed_Scroll_1);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGreen.Location = new System.Drawing.Point(127, 92);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(439, 56);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.TickFrequency = 15;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarRed_Scroll_1);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRed.Location = new System.Drawing.Point(127, 42);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(439, 56);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.TickFrequency = 15;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll_1);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(609, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // trackBarGrey
            // 
            this.trackBarGrey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGrey.Location = new System.Drawing.Point(127, 192);
            this.trackBarGrey.Maximum = 255;
            this.trackBarGrey.Name = "trackBarGrey";
            this.trackBarGrey.Size = new System.Drawing.Size(439, 56);
            this.trackBarGrey.TabIndex = 8;
            this.trackBarGrey.TickFrequency = 15;
            this.trackBarGrey.Scroll += new System.EventHandler(this.trackBarGrey_Scroll);
            // 
            // labelGrey
            // 
            this.labelGrey.AutoSize = true;
            this.labelGrey.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrey.Location = new System.Drawing.Point(46, 192);
            this.labelGrey.Name = "labelGrey";
            this.labelGrey.Size = new System.Drawing.Size(75, 28);
            this.labelGrey.TabIndex = 9;
            this.labelGrey.Text = "GREY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 586);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBarGrey;
        private System.Windows.Forms.Label labelGrey;
    }
}


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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonMaximized = new System.Windows.Forms.Button();
            this.labellogo = new System.Windows.Forms.Label();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonColorGraph = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelBack.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Transparent;
            this.panelBack.Controls.Add(this.buttonMaximized);
            this.panelBack.Controls.Add(this.labellogo);
            this.panelBack.Controls.Add(this.buttonMinimized);
            this.panelBack.Controls.Add(this.buttonClose);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(545, 35);
            this.panelBack.TabIndex = 0;
            this.panelBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
            // 
            // buttonMaximized
            // 
            this.buttonMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.buttonMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximized.FlatAppearance.BorderSize = 0;
            this.buttonMaximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximized.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMaximized.Location = new System.Drawing.Point(471, 0);
            this.buttonMaximized.Name = "buttonMaximized";
            this.buttonMaximized.Size = new System.Drawing.Size(34, 33);
            this.buttonMaximized.TabIndex = 2;
            this.buttonMaximized.Text = "🞑";
            this.buttonMaximized.UseVisualStyleBackColor = false;
            this.buttonMaximized.Click += new System.EventHandler(this.buttonMaximized_Click);
            // 
            // labellogo
            // 
            this.labellogo.AutoSize = true;
            this.labellogo.Font = new System.Drawing.Font("Arial Black", 10F);
            this.labellogo.Location = new System.Drawing.Point(12, 5);
            this.labellogo.Name = "labellogo";
            this.labellogo.Size = new System.Drawing.Size(241, 24);
            this.labellogo.TabIndex = 1;
            this.labellogo.Text = "Визуализация расчетов";
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
            this.buttonMinimized.Location = new System.Drawing.Point(431, 0);
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
            this.buttonClose.Location = new System.Drawing.Point(511, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(228)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panelGraph);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonColorGraph);
            this.panel1.Controls.Add(this.txtB);
            this.panel1.Controls.Add(this.txtK);
            this.panel1.Controls.Add(this.txtP);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRedraw);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 600);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label7.Location = new System.Drawing.Point(253, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label6.Location = new System.Drawing.Point(185, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label5.Location = new System.Drawing.Point(114, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "p";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "a";
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.chart1);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGraph.Location = new System.Drawing.Point(0, 193);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(545, 407);
            this.panelGraph.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(545, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label3.Location = new System.Drawing.Point(407, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Режим вывода";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.comboBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Точки",
            "Линии"});
            this.comboBox1.Location = new System.Drawing.Point(304, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 30);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonColorGraph
            // 
            this.buttonColorGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.buttonColorGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColorGraph.FlatAppearance.BorderSize = 0;
            this.buttonColorGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonColorGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonColorGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorGraph.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColorGraph.Location = new System.Drawing.Point(304, 64);
            this.buttonColorGraph.Name = "buttonColorGraph";
            this.buttonColorGraph.Size = new System.Drawing.Size(229, 33);
            this.buttonColorGraph.TabIndex = 10;
            this.buttonColorGraph.Text = "Цвет графика";
            this.buttonColorGraph.UseVisualStyleBackColor = false;
            this.buttonColorGraph.Click += new System.EventHandler(this.buttonColorGraph_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB.Location = new System.Drawing.Point(232, 150);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(66, 29);
            this.txtB.TabIndex = 9;
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtK.Location = new System.Drawing.Point(160, 150);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(66, 29);
            this.txtK.TabIndex = 8;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtP.Location = new System.Drawing.Point(88, 150);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(66, 29);
            this.txtP.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtA.Location = new System.Drawing.Point(16, 150);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(66, 29);
            this.txtA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Параметры";
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(175)))), ((int)(((byte)(146)))));
            this.buttonRedraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedraw.FlatAppearance.BorderSize = 0;
            this.buttonRedraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(237)))), ((int)(((byte)(209)))));
            this.buttonRedraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(184)))));
            this.buttonRedraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedraw.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedraw.Location = new System.Drawing.Point(304, 25);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(229, 33);
            this.buttonRedraw.TabIndex = 3;
            this.buttonRedraw.Text = "Перерисовать";
            this.buttonRedraw.UseVisualStyleBackColor = false;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.ghb2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F);
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "График функции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(228)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(545, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labellogo;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Button buttonMaximized;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonColorGraph;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


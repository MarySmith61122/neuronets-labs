namespace Classification
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BrowseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NN_button = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.xtextbox = new System.Windows.Forms.TextBox();
            this.ytextbox = new System.Windows.Forms.TextBox();
            this.M1 = new System.Windows.Forms.Label();
            this.M2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LR_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.w0form = new System.Windows.Forms.TextBox();
            this.w1form = new System.Windows.Forms.TextBox();
            this.w2form = new System.Windows.Forms.TextBox();
            this.k1form = new System.Windows.Forms.TextBox();
            this.b1form = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.a0form = new System.Windows.Forms.TextBox();
            this.a1form = new System.Windows.Forms.TextBox();
            this.a2form = new System.Windows.Forms.TextBox();
            this.k2form = new System.Windows.Forms.TextBox();
            this.b2form = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrowseFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BrowseFile
            // 
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(59, 24);
            this.BrowseFile.Text = "Файл";
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 601);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.b1form);
            this.panel1.Controls.Add(this.k1form);
            this.panel1.Controls.Add(this.w2form);
            this.panel1.Controls.Add(this.w1form);
            this.panel1.Controls.Add(this.w0form);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NN_button);
            this.panel1.Location = new System.Drawing.Point(154, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 294);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перцептрон";
            // 
            // NN_button
            // 
            this.NN_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NN_button.Enabled = false;
            this.NN_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NN_button.Location = new System.Drawing.Point(14, 253);
            this.NN_button.Name = "NN_button";
            this.NN_button.Size = new System.Drawing.Size(93, 24);
            this.NN_button.TabIndex = 0;
            this.NN_button.Text = "Считать";
            this.NN_button.UseVisualStyleBackColor = true;
            this.NN_button.Click += new System.EventHandler(this.NN_button_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(411, 39);
            this.chart.Name = "chart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.MarkerColor = System.Drawing.Color.Red;
            series11.MarkerSize = 10;
            series11.Name = "Группа 1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.MarkerColor = System.Drawing.Color.RoyalBlue;
            series12.MarkerSize = 10;
            series12.Name = "Группа 2";
            series13.BorderColor = System.Drawing.Color.White;
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.DarkOrange;
            series13.Legend = "Legend1";
            series13.Name = "Перцептрон";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.MarkerColor = System.Drawing.Color.LimeGreen;
            series14.MarkerSize = 10;
            series14.Name = "Series4";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.DarkViolet;
            series15.Legend = "Legend1";
            series15.Name = "Регрессия";
            this.chart.Series.Add(series11);
            this.chart.Series.Add(series12);
            this.chart.Series.Add(series13);
            this.chart.Series.Add(series14);
            this.chart.Series.Add(series15);
            this.chart.Size = new System.Drawing.Size(818, 563);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Определить точку:";
            // 
            // xtextbox
            // 
            this.xtextbox.Enabled = false;
            this.xtextbox.Location = new System.Drawing.Point(560, 621);
            this.xtextbox.Name = "xtextbox";
            this.xtextbox.Size = new System.Drawing.Size(100, 22);
            this.xtextbox.TabIndex = 5;
            this.xtextbox.TextChanged += new System.EventHandler(this.xtextbox_TextChanged);
            // 
            // ytextbox
            // 
            this.ytextbox.Enabled = false;
            this.ytextbox.Location = new System.Drawing.Point(666, 621);
            this.ytextbox.Name = "ytextbox";
            this.ytextbox.Size = new System.Drawing.Size(100, 22);
            this.ytextbox.TabIndex = 6;
            this.ytextbox.TextChanged += new System.EventHandler(this.ytextbox_TextChanged);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.BackColor = System.Drawing.Color.SandyBrown;
            this.M1.Location = new System.Drawing.Point(789, 624);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(25, 16);
            this.M1.TabIndex = 7;
            this.M1.Text = "M1";
            this.M1.Visible = false;
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.BackColor = System.Drawing.Color.MediumOrchid;
            this.M2.Location = new System.Drawing.Point(884, 624);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(25, 16);
            this.M2.TabIndex = 8;
            this.M2.Text = "M2";
            this.M2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.b2form);
            this.panel2.Controls.Add(this.k2form);
            this.panel2.Controls.Add(this.a2form);
            this.panel2.Controls.Add(this.a1form);
            this.panel2.Controls.Add(this.a0form);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LR_button);
            this.panel2.Location = new System.Drawing.Point(154, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 301);
            this.panel2.TabIndex = 9;
            // 
            // LR_button
            // 
            this.LR_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LR_button.Enabled = false;
            this.LR_button.Location = new System.Drawing.Point(14, 261);
            this.LR_button.Name = "LR_button";
            this.LR_button.Size = new System.Drawing.Size(93, 24);
            this.LR_button.TabIndex = 0;
            this.LR_button.Text = "Считать";
            this.LR_button.UseVisualStyleBackColor = true;
            this.LR_button.Click += new System.EventHandler(this.LR_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Линейная регрессия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "w0 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "w1 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "w2 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "k = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "b = ";
            // 
            // w0form
            // 
            this.w0form.Location = new System.Drawing.Point(59, 42);
            this.w0form.Name = "w0form";
            this.w0form.Size = new System.Drawing.Size(122, 22);
            this.w0form.TabIndex = 7;
            // 
            // w1form
            // 
            this.w1form.Location = new System.Drawing.Point(59, 81);
            this.w1form.Name = "w1form";
            this.w1form.Size = new System.Drawing.Size(122, 22);
            this.w1form.TabIndex = 8;
            // 
            // w2form
            // 
            this.w2form.Location = new System.Drawing.Point(59, 120);
            this.w2form.Name = "w2form";
            this.w2form.Size = new System.Drawing.Size(122, 22);
            this.w2form.TabIndex = 9;
            // 
            // k1form
            // 
            this.k1form.Location = new System.Drawing.Point(59, 173);
            this.k1form.Name = "k1form";
            this.k1form.Size = new System.Drawing.Size(122, 22);
            this.k1form.TabIndex = 10;
            // 
            // b1form
            // 
            this.b1form.Location = new System.Drawing.Point(59, 210);
            this.b1form.Name = "b1form";
            this.b1form.Size = new System.Drawing.Size(122, 22);
            this.b1form.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "a0 = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "a1 = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "a2 = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "k = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "b = ";
            // 
            // a0form
            // 
            this.a0form.Location = new System.Drawing.Point(58, 42);
            this.a0form.Name = "a0form";
            this.a0form.Size = new System.Drawing.Size(123, 22);
            this.a0form.TabIndex = 7;
            // 
            // a1form
            // 
            this.a1form.Location = new System.Drawing.Point(58, 81);
            this.a1form.Name = "a1form";
            this.a1form.Size = new System.Drawing.Size(123, 22);
            this.a1form.TabIndex = 8;
            // 
            // a2form
            // 
            this.a2form.Location = new System.Drawing.Point(58, 120);
            this.a2form.Name = "a2form";
            this.a2form.Size = new System.Drawing.Size(123, 22);
            this.a2form.TabIndex = 9;
            // 
            // k2form
            // 
            this.k2form.Location = new System.Drawing.Point(59, 173);
            this.k2form.Name = "k2form";
            this.k2form.Size = new System.Drawing.Size(122, 22);
            this.k2form.TabIndex = 10;
            // 
            // b2form
            // 
            this.b2form.Location = new System.Drawing.Point(59, 210);
            this.b2form.Name = "b2form";
            this.b2form.Size = new System.Drawing.Size(122, 22);
            this.b2form.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.ytextbox);
            this.Controls.Add(this.xtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Classification";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BrowseFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button NN_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xtextbox;
        private System.Windows.Forms.TextBox ytextbox;
        private System.Windows.Forms.Label M1;
        private System.Windows.Forms.Label M2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LR_button;
        private System.Windows.Forms.TextBox b1form;
        private System.Windows.Forms.TextBox k1form;
        private System.Windows.Forms.TextBox w2form;
        private System.Windows.Forms.TextBox w1form;
        private System.Windows.Forms.TextBox w0form;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox b2form;
        private System.Windows.Forms.TextBox k2form;
        private System.Windows.Forms.TextBox a2form;
        private System.Windows.Forms.TextBox a1form;
        private System.Windows.Forms.TextBox a0form;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}


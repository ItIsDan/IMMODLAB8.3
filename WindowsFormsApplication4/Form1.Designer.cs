﻿namespace WindowsFormsApplication4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Prob7 = new System.Windows.Forms.Label();
            this.tbpr1 = new System.Windows.Forms.NumericUpDown();
            this.tbpr2 = new System.Windows.Forms.NumericUpDown();
            this.tbpr3 = new System.Windows.Forms.NumericUpDown();
            this.tbpr6 = new System.Windows.Forms.NumericUpDown();
            this.tbpr5 = new System.Windows.Forms.NumericUpDown();
            this.tbpr4 = new System.Windows.Forms.NumericUpDown();
            this.tbN = new System.Windows.Forms.NumericUpDown();
            this.tbpr7 = new System.Windows.Forms.TextBox();
            this.tbprEx1 = new System.Windows.Forms.TextBox();
            this.tbprEx2 = new System.Windows.Forms.TextBox();
            this.tbprEx4 = new System.Windows.Forms.TextBox();
            this.tbprEx3 = new System.Windows.Forms.TextBox();
            this.tbprEx6 = new System.Windows.Forms.TextBox();
            this.tbprEx5 = new System.Windows.Forms.TextBox();
            this.tbprEx7 = new System.Windows.Forms.TextBox();
            this.tbprR7 = new System.Windows.Forms.TextBox();
            this.tbprR6 = new System.Windows.Forms.TextBox();
            this.tbprR5 = new System.Windows.Forms.TextBox();
            this.tbprR4 = new System.Windows.Forms.TextBox();
            this.tbprR3 = new System.Windows.Forms.TextBox();
            this.tbprR2 = new System.Windows.Forms.TextBox();
            this.tbprR1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(606, 39);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(760, 518);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theoretical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Experimental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "error %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prob 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prob 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prob 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prob 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prob 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Prob 4";
            // 
            // Prob7
            // 
            this.Prob7.AutoSize = true;
            this.Prob7.Location = new System.Drawing.Point(16, 254);
            this.Prob7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prob7.Name = "Prob7";
            this.Prob7.Size = new System.Drawing.Size(46, 17);
            this.Prob7.TabIndex = 10;
            this.Prob7.Text = "Prob7";
            // 
            // tbpr1
            // 
            this.tbpr1.DecimalPlaces = 2;
            this.tbpr1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr1.Location = new System.Drawing.Point(89, 44);
            this.tbpr1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr1.Name = "tbpr1";
            this.tbpr1.Size = new System.Drawing.Size(128, 22);
            this.tbpr1.TabIndex = 11;
            this.tbpr1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // tbpr2
            // 
            this.tbpr2.DecimalPlaces = 2;
            this.tbpr2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr2.Location = new System.Drawing.Point(89, 79);
            this.tbpr2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr2.Name = "tbpr2";
            this.tbpr2.Size = new System.Drawing.Size(128, 22);
            this.tbpr2.TabIndex = 12;
            this.tbpr2.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // tbpr3
            // 
            this.tbpr3.DecimalPlaces = 2;
            this.tbpr3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr3.Location = new System.Drawing.Point(89, 111);
            this.tbpr3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr3.Name = "tbpr3";
            this.tbpr3.Size = new System.Drawing.Size(128, 22);
            this.tbpr3.TabIndex = 13;
            this.tbpr3.Value = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            // 
            // tbpr6
            // 
            this.tbpr6.DecimalPlaces = 2;
            this.tbpr6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr6.Location = new System.Drawing.Point(89, 213);
            this.tbpr6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr6.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr6.Name = "tbpr6";
            this.tbpr6.Size = new System.Drawing.Size(128, 22);
            this.tbpr6.TabIndex = 16;
            this.tbpr6.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // tbpr5
            // 
            this.tbpr5.DecimalPlaces = 2;
            this.tbpr5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr5.Location = new System.Drawing.Point(89, 181);
            this.tbpr5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr5.Name = "tbpr5";
            this.tbpr5.Size = new System.Drawing.Size(128, 22);
            this.tbpr5.TabIndex = 15;
            this.tbpr5.Value = new decimal(new int[] {
            14,
            0,
            0,
            131072});
            // 
            // tbpr4
            // 
            this.tbpr4.DecimalPlaces = 2;
            this.tbpr4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr4.Location = new System.Drawing.Point(89, 146);
            this.tbpr4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr4.Name = "tbpr4";
            this.tbpr4.Size = new System.Drawing.Size(128, 22);
            this.tbpr4.TabIndex = 14;
            this.tbpr4.Value = new decimal(new int[] {
            12,
            0,
            0,
            131072});
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(293, 348);
            this.tbN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(84, 22);
            this.tbN.TabIndex = 17;
            this.tbN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tbpr7
            // 
            this.tbpr7.Location = new System.Drawing.Point(89, 250);
            this.tbpr7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpr7.Name = "tbpr7";
            this.tbpr7.ReadOnly = true;
            this.tbpr7.Size = new System.Drawing.Size(127, 22);
            this.tbpr7.TabIndex = 18;
            // 
            // tbprEx1
            // 
            this.tbprEx1.Location = new System.Drawing.Point(279, 47);
            this.tbprEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx1.Name = "tbprEx1";
            this.tbprEx1.ReadOnly = true;
            this.tbprEx1.Size = new System.Drawing.Size(127, 22);
            this.tbprEx1.TabIndex = 19;
            // 
            // tbprEx2
            // 
            this.tbprEx2.Location = new System.Drawing.Point(279, 81);
            this.tbprEx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx2.Name = "tbprEx2";
            this.tbprEx2.ReadOnly = true;
            this.tbprEx2.Size = new System.Drawing.Size(127, 22);
            this.tbprEx2.TabIndex = 20;
            // 
            // tbprEx4
            // 
            this.tbprEx4.Location = new System.Drawing.Point(279, 148);
            this.tbprEx4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx4.Name = "tbprEx4";
            this.tbprEx4.ReadOnly = true;
            this.tbprEx4.Size = new System.Drawing.Size(127, 22);
            this.tbprEx4.TabIndex = 22;
            // 
            // tbprEx3
            // 
            this.tbprEx3.Location = new System.Drawing.Point(279, 113);
            this.tbprEx3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx3.Name = "tbprEx3";
            this.tbprEx3.ReadOnly = true;
            this.tbprEx3.Size = new System.Drawing.Size(127, 22);
            this.tbprEx3.TabIndex = 21;
            // 
            // tbprEx6
            // 
            this.tbprEx6.Location = new System.Drawing.Point(279, 218);
            this.tbprEx6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx6.Name = "tbprEx6";
            this.tbprEx6.ReadOnly = true;
            this.tbprEx6.Size = new System.Drawing.Size(127, 22);
            this.tbprEx6.TabIndex = 24;
            // 
            // tbprEx5
            // 
            this.tbprEx5.Location = new System.Drawing.Point(279, 183);
            this.tbprEx5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx5.Name = "tbprEx5";
            this.tbprEx5.ReadOnly = true;
            this.tbprEx5.Size = new System.Drawing.Size(127, 22);
            this.tbprEx5.TabIndex = 23;
            // 
            // tbprEx7
            // 
            this.tbprEx7.Location = new System.Drawing.Point(279, 250);
            this.tbprEx7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprEx7.Name = "tbprEx7";
            this.tbprEx7.ReadOnly = true;
            this.tbprEx7.Size = new System.Drawing.Size(127, 22);
            this.tbprEx7.TabIndex = 25;
            // 
            // tbprR7
            // 
            this.tbprR7.Location = new System.Drawing.Point(460, 250);
            this.tbprR7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR7.Name = "tbprR7";
            this.tbprR7.ReadOnly = true;
            this.tbprR7.Size = new System.Drawing.Size(127, 22);
            this.tbprR7.TabIndex = 32;
            // 
            // tbprR6
            // 
            this.tbprR6.Location = new System.Drawing.Point(460, 218);
            this.tbprR6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR6.Name = "tbprR6";
            this.tbprR6.ReadOnly = true;
            this.tbprR6.Size = new System.Drawing.Size(127, 22);
            this.tbprR6.TabIndex = 31;
            // 
            // tbprR5
            // 
            this.tbprR5.Location = new System.Drawing.Point(460, 183);
            this.tbprR5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR5.Name = "tbprR5";
            this.tbprR5.ReadOnly = true;
            this.tbprR5.Size = new System.Drawing.Size(127, 22);
            this.tbprR5.TabIndex = 30;
            // 
            // tbprR4
            // 
            this.tbprR4.Location = new System.Drawing.Point(460, 148);
            this.tbprR4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR4.Name = "tbprR4";
            this.tbprR4.ReadOnly = true;
            this.tbprR4.Size = new System.Drawing.Size(127, 22);
            this.tbprR4.TabIndex = 29;
            // 
            // tbprR3
            // 
            this.tbprR3.Location = new System.Drawing.Point(460, 113);
            this.tbprR3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR3.Name = "tbprR3";
            this.tbprR3.ReadOnly = true;
            this.tbprR3.Size = new System.Drawing.Size(127, 22);
            this.tbprR3.TabIndex = 28;
            // 
            // tbprR2
            // 
            this.tbprR2.Location = new System.Drawing.Point(460, 81);
            this.tbprR2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR2.Name = "tbprR2";
            this.tbprR2.ReadOnly = true;
            this.tbprR2.Size = new System.Drawing.Size(127, 22);
            this.tbprR2.TabIndex = 27;
            // 
            // tbprR1
            // 
            this.tbprR1.Location = new System.Drawing.Point(460, 47);
            this.tbprR1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbprR1.Name = "tbprR1";
            this.tbprR1.ReadOnly = true;
            this.tbprR1.Size = new System.Drawing.Size(127, 22);
            this.tbprR1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Number of experiments";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 74);
            this.button1.TabIndex = 34;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbprR7);
            this.Controls.Add(this.tbprR6);
            this.Controls.Add(this.tbprR5);
            this.Controls.Add(this.tbprR4);
            this.Controls.Add(this.tbprR3);
            this.Controls.Add(this.tbprR2);
            this.Controls.Add(this.tbprR1);
            this.Controls.Add(this.tbprEx7);
            this.Controls.Add(this.tbprEx6);
            this.Controls.Add(this.tbprEx5);
            this.Controls.Add(this.tbprEx4);
            this.Controls.Add(this.tbprEx3);
            this.Controls.Add(this.tbprEx2);
            this.Controls.Add(this.tbprEx1);
            this.Controls.Add(this.tbpr7);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbpr6);
            this.Controls.Add(this.tbpr5);
            this.Controls.Add(this.tbpr4);
            this.Controls.Add(this.tbpr3);
            this.Controls.Add(this.tbpr2);
            this.Controls.Add(this.tbpr1);
            this.Controls.Add(this.Prob7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Prob7;
        private System.Windows.Forms.NumericUpDown tbpr1;
        private System.Windows.Forms.NumericUpDown tbpr2;
        private System.Windows.Forms.NumericUpDown tbpr3;
        private System.Windows.Forms.NumericUpDown tbpr6;
        private System.Windows.Forms.NumericUpDown tbpr5;
        private System.Windows.Forms.NumericUpDown tbpr4;
        private System.Windows.Forms.NumericUpDown tbN;
        private System.Windows.Forms.TextBox tbpr7;
        private System.Windows.Forms.TextBox tbprEx1;
        private System.Windows.Forms.TextBox tbprEx2;
        private System.Windows.Forms.TextBox tbprEx4;
        private System.Windows.Forms.TextBox tbprEx3;
        private System.Windows.Forms.TextBox tbprEx6;
        private System.Windows.Forms.TextBox tbprEx5;
        private System.Windows.Forms.TextBox tbprEx7;
        private System.Windows.Forms.TextBox tbprR7;
        private System.Windows.Forms.TextBox tbprR6;
        private System.Windows.Forms.TextBox tbprR5;
        private System.Windows.Forms.TextBox tbprR4;
        private System.Windows.Forms.TextBox tbprR3;
        private System.Windows.Forms.TextBox tbprR2;
        private System.Windows.Forms.TextBox tbprR1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}


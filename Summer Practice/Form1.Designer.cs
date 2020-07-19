namespace Summer_Practice
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graphField = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.valueTable = new System.Windows.Forms.DataGridView();
            this.timeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subBValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.numericUpDownSpeedK2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedK1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSubC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSubB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSubA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAnalytical = new System.Windows.Forms.Button();
            this.buttonEiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTable)).BeginInit();
            this.groupBoxUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphField
            // 
            chartArea2.Name = "ChartArea1";
            this.graphField.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graphField.Legends.Add(legend2);
            this.graphField.Location = new System.Drawing.Point(12, 12);
            this.graphField.Name = "graphField";
            this.graphField.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "product A";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "product B";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Green;
            series9.Legend = "Legend1";
            series9.Name = "product C";
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Blue;
            series10.Legend = "Legend1";
            series10.Name = "accuracy A";
            series11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.Name = "accuracy B";
            series12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Green;
            series12.Legend = "Legend1";
            series12.Name = "accuracy C";
            this.graphField.Series.Add(series7);
            this.graphField.Series.Add(series8);
            this.graphField.Series.Add(series9);
            this.graphField.Series.Add(series10);
            this.graphField.Series.Add(series11);
            this.graphField.Series.Add(series12);
            this.graphField.Size = new System.Drawing.Size(552, 315);
            this.graphField.TabIndex = 0;
            this.graphField.Text = "chart1";
            // 
            // valueTable
            // 
            this.valueTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeValue,
            this.subAValue,
            this.subBValue,
            this.subCValue});
            this.valueTable.Location = new System.Drawing.Point(538, 12);
            this.valueTable.Name = "valueTable";
            this.valueTable.RowHeadersVisible = false;
            this.valueTable.Size = new System.Drawing.Size(401, 315);
            this.valueTable.TabIndex = 1;
            // 
            // timeValue
            // 
            this.timeValue.HeaderText = "Time";
            this.timeValue.Name = "timeValue";
            this.timeValue.ReadOnly = true;
            // 
            // subAValue
            // 
            this.subAValue.HeaderText = "Substance A";
            this.subAValue.Name = "subAValue";
            this.subAValue.ReadOnly = true;
            // 
            // subBValue
            // 
            this.subBValue.HeaderText = "Substance B";
            this.subBValue.Name = "subBValue";
            this.subBValue.ReadOnly = true;
            // 
            // subCValue
            // 
            this.subCValue.HeaderText = "Substance C";
            this.subCValue.Name = "subCValue";
            this.subCValue.ReadOnly = true;
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.numericUpDownSpeedK2);
            this.groupBoxUserData.Controls.Add(this.label9);
            this.groupBoxUserData.Controls.Add(this.numericUpDownSpeedK1);
            this.groupBoxUserData.Controls.Add(this.label8);
            this.groupBoxUserData.Controls.Add(this.numericUpDownMax);
            this.groupBoxUserData.Controls.Add(this.label7);
            this.groupBoxUserData.Controls.Add(this.numericUpDownMin);
            this.groupBoxUserData.Controls.Add(this.label6);
            this.groupBoxUserData.Controls.Add(this.numericUpDownTime);
            this.groupBoxUserData.Controls.Add(this.label5);
            this.groupBoxUserData.Controls.Add(this.numericUpDownSubC);
            this.groupBoxUserData.Controls.Add(this.label4);
            this.groupBoxUserData.Controls.Add(this.numericUpDownSubB);
            this.groupBoxUserData.Controls.Add(this.label3);
            this.groupBoxUserData.Controls.Add(this.numericUpDownSubA);
            this.groupBoxUserData.Controls.Add(this.label2);
            this.groupBoxUserData.Controls.Add(this.label1);
            this.groupBoxUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxUserData.Location = new System.Drawing.Point(945, 117);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(292, 210);
            this.groupBoxUserData.TabIndex = 3;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "Your data ";
            // 
            // numericUpDownSpeedK2
            // 
            this.numericUpDownSpeedK2.Location = new System.Drawing.Point(165, 178);
            this.numericUpDownSpeedK2.Name = "numericUpDownSpeedK2";
            this.numericUpDownSpeedK2.Size = new System.Drawing.Size(43, 23);
            this.numericUpDownSpeedK2.TabIndex = 14;
            this.numericUpDownSpeedK2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Speed of reaction (k2):";
            // 
            // numericUpDownSpeedK1
            // 
            this.numericUpDownSpeedK1.Location = new System.Drawing.Point(165, 149);
            this.numericUpDownSpeedK1.Name = "numericUpDownSpeedK1";
            this.numericUpDownSpeedK1.Size = new System.Drawing.Size(43, 23);
            this.numericUpDownSpeedK1.TabIndex = 13;
            this.numericUpDownSpeedK1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Speed of reaction (k1):";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(233, 120);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(38, 23);
            this.numericUpDownMax.TabIndex = 12;
            this.numericUpDownMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "max";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(146, 120);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(42, 23);
            this.numericUpDownMin.TabIndex = 11;
            this.numericUpDownMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "min";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(55, 94);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(43, 23);
            this.numericUpDownTime.TabIndex = 10;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "An accuracy (%):";
            // 
            // numericUpDownSubC
            // 
            this.numericUpDownSubC.Location = new System.Drawing.Point(237, 73);
            this.numericUpDownSubC.Name = "numericUpDownSubC";
            this.numericUpDownSubC.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownSubC.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time:";
            // 
            // numericUpDownSubB
            // 
            this.numericUpDownSubB.Location = new System.Drawing.Point(237, 47);
            this.numericUpDownSubB.Name = "numericUpDownSubB";
            this.numericUpDownSubB.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownSubB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "The concentration of substance C:";
            // 
            // numericUpDownSubA
            // 
            this.numericUpDownSubA.Location = new System.Drawing.Point(237, 20);
            this.numericUpDownSubA.Name = "numericUpDownSubA";
            this.numericUpDownSubA.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownSubA.TabIndex = 7;
            this.numericUpDownSubA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "The concentration of substance B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "The concentration of substance A:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(945, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAnalytical
            // 
            this.buttonAnalytical.Location = new System.Drawing.Point(945, 50);
            this.buttonAnalytical.Name = "buttonAnalytical";
            this.buttonAnalytical.Size = new System.Drawing.Size(140, 28);
            this.buttonAnalytical.TabIndex = 5;
            this.buttonAnalytical.Text = "Analytical method";
            this.buttonAnalytical.UseVisualStyleBackColor = true;
            this.buttonAnalytical.Click += new System.EventHandler(this.buttonAnalytical_Click);
            // 
            // buttonEiler
            // 
            this.buttonEiler.Location = new System.Drawing.Point(945, 84);
            this.buttonEiler.Name = "buttonEiler";
            this.buttonEiler.Size = new System.Drawing.Size(140, 28);
            this.buttonEiler.TabIndex = 6;
            this.buttonEiler.Text = "Eiler method";
            this.buttonEiler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 334);
            this.Controls.Add(this.buttonEiler);
            this.Controls.Add(this.buttonAnalytical);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.valueTable);
            this.Controls.Add(this.graphField);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTable)).EndInit();
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphField;
        private System.Windows.Forms.DataGridView valueTable;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAnalytical;
        private System.Windows.Forms.Button buttonEiler;
        private System.Windows.Forms.NumericUpDown numericUpDownSubA;
        private System.Windows.Forms.NumericUpDown numericUpDownSubB;
        private System.Windows.Forms.NumericUpDown numericUpDownSubC;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedK1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn subBValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCValue;
    }
}


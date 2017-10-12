namespace LemerAlgoritm.UI.WinForms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.radiobtnCalcUntilPeriod = new System.Windows.Forms.RadioButton();
            this.groupBoxChoise = new System.Windows.Forms.GroupBox();
            this.radiobtnSetN = new System.Windows.Forms.RadioButton();
            this.numericUpDownExpectedNumberOfValues = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblActualN = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR0 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelM = new System.Windows.Forms.Label();
            this.labelR0 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.listBoxTransformedValues = new System.Windows.Forms.ListBox();
            this.btnDrawBarChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPi4 = new System.Windows.Forms.Label();
            this.lbl2KN = new System.Windows.Forms.Label();
            this.groupBoxChoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpectedNumberOfValues)).BeginInit();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.Location = new System.Drawing.Point(311, 41);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(213, 251);
            this.listBoxValues.TabIndex = 0;
            // 
            // radiobtnCalcUntilPeriod
            // 
            this.radiobtnCalcUntilPeriod.AutoSize = true;
            this.radiobtnCalcUntilPeriod.Checked = true;
            this.radiobtnCalcUntilPeriod.Location = new System.Drawing.Point(37, 31);
            this.radiobtnCalcUntilPeriod.Name = "radiobtnCalcUntilPeriod";
            this.radiobtnCalcUntilPeriod.Size = new System.Drawing.Size(129, 17);
            this.radiobtnCalcUntilPeriod.TabIndex = 1;
            this.radiobtnCalcUntilPeriod.TabStop = true;
            this.radiobtnCalcUntilPeriod.Text = "До первого периода";
            this.radiobtnCalcUntilPeriod.UseVisualStyleBackColor = true;
            this.radiobtnCalcUntilPeriod.CheckedChanged += new System.EventHandler(this.radiobtnCalcUntilPeriod_CheckedChanged);
            // 
            // groupBoxChoise
            // 
            this.groupBoxChoise.Controls.Add(this.radiobtnSetN);
            this.groupBoxChoise.Controls.Add(this.numericUpDownExpectedNumberOfValues);
            this.groupBoxChoise.Controls.Add(this.radiobtnCalcUntilPeriod);
            this.groupBoxChoise.Location = new System.Drawing.Point(28, 187);
            this.groupBoxChoise.Name = "groupBoxChoise";
            this.groupBoxChoise.Size = new System.Drawing.Size(220, 121);
            this.groupBoxChoise.TabIndex = 2;
            this.groupBoxChoise.TabStop = false;
            this.groupBoxChoise.Text = "Количество сгенерированных чисел:";
            // 
            // radiobtnSetN
            // 
            this.radiobtnSetN.AutoSize = true;
            this.radiobtnSetN.Location = new System.Drawing.Point(37, 65);
            this.radiobtnSetN.Name = "radiobtnSetN";
            this.radiobtnSetN.Size = new System.Drawing.Size(110, 17);
            this.radiobtnSetN.TabIndex = 2;
            this.radiobtnSetN.Text = "Задать вручную";
            this.radiobtnSetN.UseVisualStyleBackColor = true;
            // 
            // numericUpDownExpectedNumberOfValues
            // 
            this.numericUpDownExpectedNumberOfValues.Location = new System.Drawing.Point(38, 88);
            this.numericUpDownExpectedNumberOfValues.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownExpectedNumberOfValues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExpectedNumberOfValues.Name = "numericUpDownExpectedNumberOfValues";
            this.numericUpDownExpectedNumberOfValues.Size = new System.Drawing.Size(129, 21);
            this.numericUpDownExpectedNumberOfValues.TabIndex = 5;
            this.numericUpDownExpectedNumberOfValues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExpectedNumberOfValues.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(66, 314);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblActualN
            // 
            this.lblActualN.AutoSize = true;
            this.lblActualN.Location = new System.Drawing.Point(423, 295);
            this.lblActualN.Name = "lblActualN";
            this.lblActualN.Size = new System.Drawing.Size(41, 13);
            this.lblActualN.TabIndex = 4;
            this.lblActualN.Text = "Итого:";
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.numericUpDownM);
            this.groupBoxParams.Controls.Add(this.numericUpDownR0);
            this.groupBoxParams.Controls.Add(this.numericUpDownA);
            this.groupBoxParams.Controls.Add(this.labelM);
            this.groupBoxParams.Controls.Add(this.labelR0);
            this.groupBoxParams.Controls.Add(this.labelA);
            this.groupBoxParams.Location = new System.Drawing.Point(28, 41);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(220, 122);
            this.groupBoxParams.TabIndex = 5;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры:";
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(80, 86);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownM.TabIndex = 5;
            this.numericUpDownM.Value = new decimal(new int[] {
            50023,
            0,
            0,
            0});
            // 
            // numericUpDownR0
            // 
            this.numericUpDownR0.Location = new System.Drawing.Point(80, 58);
            this.numericUpDownR0.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDownR0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownR0.Name = "numericUpDownR0";
            this.numericUpDownR0.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownR0.TabIndex = 4;
            this.numericUpDownR0.Value = new decimal(new int[] {
            50021,
            0,
            0,
            0});
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(80, 31);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownA.TabIndex = 3;
            this.numericUpDownA.Value = new decimal(new int[] {
            32771,
            0,
            0,
            0});
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(46, 88);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(15, 13);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "m";
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Location = new System.Drawing.Point(41, 60);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(20, 13);
            this.labelR0.TabIndex = 1;
            this.labelR0.Text = "R0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(46, 33);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(13, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a";
            // 
            // listBoxTransformedValues
            // 
            this.listBoxTransformedValues.FormattingEnabled = true;
            this.listBoxTransformedValues.Location = new System.Drawing.Point(569, 41);
            this.listBoxTransformedValues.Name = "listBoxTransformedValues";
            this.listBoxTransformedValues.Size = new System.Drawing.Size(193, 251);
            this.listBoxTransformedValues.TabIndex = 6;
            // 
            // btnDrawBarChart
            // 
            this.btnDrawBarChart.Location = new System.Drawing.Point(338, 314);
            this.btnDrawBarChart.Name = "btnDrawBarChart";
            this.btnDrawBarChart.Size = new System.Drawing.Size(159, 23);
            this.btnDrawBarChart.TabIndex = 7;
            this.btnDrawBarChart.Text = "Построить гистограмму";
            this.btnDrawBarChart.UseVisualStyleBackColor = true;
            this.btnDrawBarChart.Click += new System.EventHandler(this.btnDrawBarChart_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(28, 343);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(725, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Математическое ожидание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дисперсия: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Среднеквадратичное отклонение:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(768, 63);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(25, 13);
            this.lblM.TabIndex = 12;
            this.lblM.Text = "111";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(768, 127);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(25, 13);
            this.lblD.TabIndex = 13;
            this.lblD.Text = "111";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(768, 201);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(25, 13);
            this.lblQ.TabIndex = 14;
            this.lblQ.Text = "111";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(569, 314);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(193, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Проверка по косвенным признакам";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "P / 4 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "2K / N =";
            // 
            // lblPi4
            // 
            this.lblPi4.AutoSize = true;
            this.lblPi4.Location = new System.Drawing.Point(814, 343);
            this.lblPi4.Name = "lblPi4";
            this.lblPi4.Size = new System.Drawing.Size(0, 13);
            this.lblPi4.TabIndex = 18;
            // 
            // lbl2KN
            // 
            this.lbl2KN.AutoSize = true;
            this.lbl2KN.Location = new System.Drawing.Point(817, 378);
            this.lbl2KN.Name = "lbl2KN";
            this.lbl2KN.Size = new System.Drawing.Size(0, 13);
            this.lbl2KN.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(961, 689);
            this.Controls.Add(this.lbl2KN);
            this.Controls.Add(this.lblPi4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnDrawBarChart);
            this.Controls.Add(this.listBoxTransformedValues);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.lblActualN);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBoxChoise);
            this.Controls.Add(this.listBoxValues);
            this.Name = "MainForm";
            this.Text = "Генератор последовательности равномерно распределенных случайных чисел";
            this.groupBoxChoise.ResumeLayout(false);
            this.groupBoxChoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpectedNumberOfValues)).EndInit();
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.RadioButton radiobtnCalcUntilPeriod;
        private System.Windows.Forms.GroupBox groupBoxChoise;
        private System.Windows.Forms.RadioButton radiobtnSetN;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblActualN;
        private System.Windows.Forms.NumericUpDown numericUpDownExpectedNumberOfValues;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownR0;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.ListBox listBoxTransformedValues;
        private System.Windows.Forms.Button btnDrawBarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPi4;
        private System.Windows.Forms.Label lbl2KN;
    }
}


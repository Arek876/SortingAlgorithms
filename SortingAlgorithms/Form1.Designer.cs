namespace SortingAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxSort = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxCiag = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPointsAmount = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxSortType = new System.Windows.Forms.CheckedListBox();
            this.checkBoxPointsAmount = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointsAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 408);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Ilość elementów";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.Title = "Czas (sekundy)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(216, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BubbleSort";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "InsertionSort";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SelectionSort";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "QuickSort";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "MergeSort";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(886, 591);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sortowanie:";
            // 
            // checkedListBoxSort
            // 
            this.checkedListBoxSort.FormattingEnabled = true;
            this.checkedListBoxSort.Items.AddRange(new object[] {
            "Bubble",
            "Insertion",
            "Selection",
            "Quick",
            "Merge"});
            this.checkedListBoxSort.Location = new System.Drawing.Point(3, 19);
            this.checkedListBoxSort.Name = "checkedListBoxSort";
            this.checkedListBoxSort.Size = new System.Drawing.Size(120, 106);
            this.checkedListBoxSort.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kolejność:";
            // 
            // checkedListBoxCiag
            // 
            this.checkedListBoxCiag.FormattingEnabled = true;
            this.checkedListBoxCiag.Items.AddRange(new object[] {
            "losowo",
            "rosnąco",
            "malejąco"});
            this.checkedListBoxCiag.Location = new System.Drawing.Point(3, 147);
            this.checkedListBoxCiag.Name = "checkedListBoxCiag";
            this.checkedListBoxCiag.Size = new System.Drawing.Size(120, 72);
            this.checkedListBoxCiag.TabIndex = 11;
            this.checkedListBoxCiag.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCiag_ItemCheck);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(3, 318);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAmount.TabIndex = 12;
            // 
            // numericUpDownPointsAmount
            // 
            this.numericUpDownPointsAmount.Enabled = false;
            this.numericUpDownPointsAmount.Location = new System.Drawing.Point(27, 359);
            this.numericUpDownPointsAmount.Name = "numericUpDownPointsAmount";
            this.numericUpDownPointsAmount.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownPointsAmount.TabIndex = 13;
            this.numericUpDownPointsAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkedListBoxSortType
            // 
            this.checkedListBoxSortType.FormattingEnabled = true;
            this.checkedListBoxSortType.Items.AddRange(new object[] {
            "słupkowy",
            "liniowy"});
            this.checkedListBoxSortType.Location = new System.Drawing.Point(3, 241);
            this.checkedListBoxSortType.Name = "checkedListBoxSortType";
            this.checkedListBoxSortType.Size = new System.Drawing.Size(120, 55);
            this.checkedListBoxSortType.TabIndex = 14;
            this.checkedListBoxSortType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSortType_ItemCheck);
            // 
            // checkBoxPointsAmount
            // 
            this.checkBoxPointsAmount.AutoSize = true;
            this.checkBoxPointsAmount.Location = new System.Drawing.Point(3, 362);
            this.checkBoxPointsAmount.Name = "checkBoxPointsAmount";
            this.checkBoxPointsAmount.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPointsAmount.TabIndex = 15;
            this.checkBoxPointsAmount.UseVisualStyleBackColor = true;
            this.checkBoxPointsAmount.CheckedChanged += new System.EventHandler(this.checkBoxPointsAmount_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ilość Punktów:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownPointsAmount);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.checkBoxPointsAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkedListBoxSort);
            this.panel1.Controls.Add(this.checkedListBoxSortType);
            this.panel1.Controls.Add(this.numericUpDownAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBoxCiag);
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 473);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wykres:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointsAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxCiag;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPointsAmount;
        private System.Windows.Forms.CheckedListBox checkedListBoxSortType;
        private System.Windows.Forms.CheckBox checkBoxPointsAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}


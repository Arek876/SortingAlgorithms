using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SortingAlgorithms.Form1;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Titles.Add("Sort chart");

            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Minimum = 0;

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            //--------------------------------wybór typu wykresu--------------------------------
            if (checkedListBoxSortType.GetItemCheckState(1) == CheckState.Checked)
            {
                foreach (var series in chart1.Series)
                {
                    series.ChartType = SeriesChartType.Line;
                }

            }
            else
            {
                foreach (var series in chart1.Series)
                {
                    series.ChartType = SeriesChartType.Column;
                }
            }
            //-----------------------------------Dane----------------------------------------------
            int amount = (int)numericUpDownAmount.Value;
            int iloscPunktow = (int)numericUpDownPointsAmount.Value;

            amount = amount / iloscPunktow;
            int divided = amount;

            //---------------------------------2 tablice------------------------------------------------
            for (int l = 0; l < iloscPunktow; l++)
            {
                int[] data = new int[amount];
                int[] dataCopy;
                double[] Result = new double[checkedListBoxSort.CheckedItems.Count];
                int k = 0;
                //------------------------------------Lista---------------------------------------------



                //int[] data= new int[amount];

                List<Sortowania> sorts = new List<Sortowania>()
                {
                new BubbleSort(),
                new InsertionSort(),
                new SelectionSort(),
                new QuickSort(),
                new MergeSort()
                };
                //----------------------------------Usuniecie z listy niepotrzebnych sortowan-----------------------------------------------
                if (checkedListBoxSort.CheckedItems.Count == 0)
                {
                    MessageBox.Show("nie wybrano sortowania!");
                    return;
                }

                if (checkedListBoxSort.GetItemCheckState(3) == CheckState.Checked && amount > 10000 && (checkedListBoxCiag.GetItemCheckState(1) == CheckState.Checked || checkedListBoxCiag.GetItemCheckState(2) == CheckState.Checked))
                {
                    MessageBox.Show("QuickSort przy ciągu rosnącym i malejącym może mieć maksymalnie 10000 elementów");
                    return;

                }
                for (int i = checkedListBoxSort.Items.Count - 1; i >= 0; --i)
                {
                    if (checkedListBoxSort.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        sorts.RemoveAt(i); 
                    }
                }
                //-----------------------------------Ciag----------------------------------------------
                if (checkedListBoxCiag.GetItemCheckState(0) == CheckState.Checked)
                {
                    Random rand = new Random();
                    for (int j = 0; j < amount; j++)
                    {
                        data[j] = rand.Next(0, amount + 1);

                    }

                }
                else if (checkedListBoxCiag.GetItemCheckState(1) == CheckState.Checked)
                {

                    for (int j = 0; j < amount; j++)
                    {
                        data[j] = j;
                    }
                }
                else if (checkedListBoxCiag.GetItemCheckState(2) == CheckState.Checked)
                {
                    for (int j = 0; j < amount; j++)
                    {
                        data[j] = amount - j;
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano ciagu!");
                    return;

                }
                //-----------------------------------Przejscie po liscie sortowan----------------------------------------------
                foreach (Sortowania sort in sorts)
                {
                    Stopwatch time = new Stopwatch();
                    time.Restart();


                    dataCopy = (int[])data.Clone();
                    if (sort.GetType().Name == "QuickSort" || sort.GetType().Name == "MergeSort")
                    {

                        time.Start();
                        sort.Sort2(dataCopy, 0, dataCopy.Length - 1);
                        time.Stop();
                    }
                    else
                    {

                        time.Start();
                        sort.Sort(dataCopy);
                        time.Stop();
                    }

                    Result[k] = ((double)time.ElapsedMilliseconds / 1000);

                    k++;
                    chart1.Series[$"{sort.GetType().Name}"].Points.AddXY(amount, (double)time.ElapsedMilliseconds / 1000);
                }
                amount += divided;
            }
            MessageBox.Show("Gotowe");

        }

        private void checkBoxPointsAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPointsAmount.CheckState == CheckState.Unchecked)
            {
                numericUpDownPointsAmount.Value = 2;
                numericUpDownPointsAmount.Enabled = false;
            }
            else
            {
                numericUpDownPointsAmount.Enabled = true;

            }
        }

        private void checkedListBoxSortType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxSortType.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    checkedListBoxSortType.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBoxCiag_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxCiag.Items.Count; ++i)
            {

                if (i != e.Index)
                {
                    checkedListBoxCiag.SetItemChecked(i, false);
                }
            }
        }
    }

}
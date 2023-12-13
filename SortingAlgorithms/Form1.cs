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

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Random rand=new Random();
        Stopwatch time= new Stopwatch();*/

        private void startButton_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDownAmount.Value;
            int from = (int)numericUpDownFrom.Value;
            int to = (int)numericUpDownTo.Value;

            Random rand = new Random();

            int[] data= new int[amount];

            List<Sortowania> sorts = new List<Sortowania>()
            {
                new BubbleSort(),
                new InsertionSort(),
                new SelectionSort(),
                new QuickSort()
            };

            foreach(Sortowania sort in sorts)
            {
                for (int j = 0; j < amount; j++)
                {
                    data[j] = rand.Next(from, to + 1);
                }
                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine(data[j]);
                }
                if(sort.GetType().Name!="QuickSort")
                {
                    sort.Sort(data);
                }
                else
                {
                    sort.Sort2(data, 0, data.Length - 1);
                }
                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine($"{sort.GetType().Name}: {data[j]}");
                }
            }
            MessageBox.Show("Gotowe");
        }
        public abstract class Sortowania
        {
            public virtual void Sort(int[] data)
            {

            }
            public virtual void Sort2(int[] data,int left, int right)
            {

            }
        }
    }
}

/*            BubbleSort bSort = new BubbleSort();

            int amount=int.Parse(textAmount.Text);
            int From= int.Parse(textFrom.Text);
            int To= int.Parse(textTo.Text);
            int[] data = new int[amount];

            for(int i=0; i<data.Length;i++)
            {
                data[i]=rand.Next(From,To+1);
            }

            time.Restart();
            time.Start();
            bSort.Sort(data);
            time.Stop();

            MessageBox.Show($"Amount: {textAmount.Text}");
            MessageBox.Show($"time:{time.Elapsed}");*/
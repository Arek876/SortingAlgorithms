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
        Random rand=new Random();
        Stopwatch time= new Stopwatch();

        private void startButton_Click(object sender, EventArgs e)
        {
            BubbleSort bSort = new BubbleSort();

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
            MessageBox.Show($"time:{time.Elapsed}");
        }
    }
}

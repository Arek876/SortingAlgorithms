using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SortingAlgorithms.Form1;


namespace SortingAlgorithms
{
    public class SelectionSort : Sortowania
    {
        public override void Sort(int[] data)
        {
            int n=data.Length;
            for(int i=0; i<n-1;i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (data[j]< data[min])
                    {
                        min = j;
                    }

                }
                int temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        }
    }
}

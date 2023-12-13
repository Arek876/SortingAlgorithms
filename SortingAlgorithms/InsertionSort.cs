using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SortingAlgorithms.Form1;


namespace SortingAlgorithms
{
    public class InsertionSort : Sortowania
    {
        public override void Sort(int[] data)
        {
            for(int i=1;i<data.Length; i++)
            {
                int key = data[i];
                int j = i - 1;

                while(j >= 0 && data[j]>key)
                {
                    data[j + 1] = data[j];
                    j=j - 1;
                }
                data[j + 1] = key;
            }
        }
    }
}

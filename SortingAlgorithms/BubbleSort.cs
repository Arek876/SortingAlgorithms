using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public void Sort(int[] data) 
        { 
            for(int i = 0;i<data.Length; i++)
            {
                for(int j=0;j<data.Length-1;j++)
                {
                    if (data[j] > data[j+1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}

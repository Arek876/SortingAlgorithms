using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SortingAlgorithms.Form1;


namespace SortingAlgorithms
{
    public class QuickSort : Sortowania
    {
        public override void Sort2(int[] data, int l, int r)
        {
            if(l<r)
            {
                int pivot = Divide(data, l, r);
                Sort2(data, l, pivot - 1);
                Sort2(data, pivot + 1, r);
            }
        }
        private int Divide(int[] data, int l, int r)
        {
            int pivot = data[r];
            int i = (l - 1);

            for(int j=l;j<r;j++)
            {
                if (data[j] <= pivot)
                {
                    i++;
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
            int temp1 = data[i + 1];
            data[i + 1] = data[r];
            data[r] = temp1;

            return i + 1;
        }
    }
}

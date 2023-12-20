using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort : Sortowania
    {
        public override void Sort2(int[] data, int l, int r)
        {
            if (l < r)
            {
                int middle = (l + r) / 2;

                Sort2(data, l, middle);
                Sort2(data, middle + 1, r);

                Merge(data, l, middle, r);
            }
        }
        private void Merge(int[] data, int l, int middle, int r)
        {
            int[] lData = new int[middle - l + 1];
            int[] rData = new int[r - middle];

            Array.Copy(data, l, lData, 0, middle - l + 1);
            Array.Copy(data, middle + 1, rData, 0, r - middle);

            int i = 0;
            int j = 0;
            for (int k = l; k < r + 1; k++)
            {
                if (i == lData.Length)
                {
                    data[k] = rData[j];
                    j++;
                }
                else if (j == rData.Length)
                {
                    data[k] = lData[i];
                    i++;
                }
                else if (lData[i] <= rData[j])
                {
                    data[k] = lData[i];
                    i++;
                }
                else
                {
                    data[k] = rData[j];
                    j++;
                }
            }
        }
    }
}

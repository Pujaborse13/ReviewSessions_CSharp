using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    //Q.9 Test Sorting Algorithm: Write NUnit tests for sorting functions (Bubble Sort
    public class BubbleSort
    {
        public int[] UsingBubbleSort(int[] arr)
        {
            int n = arr.Length -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                    
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

    }
}

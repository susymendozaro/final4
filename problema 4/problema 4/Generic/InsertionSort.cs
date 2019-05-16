using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_4.Generic
{
    class InsertionSort
    {

        public static void InsertionSort<T>(T[] arr, int n) where T : IComparable
        {
            int i, j;
            T key;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}

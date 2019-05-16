using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problema_4.Class;



namespace problema_4
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] arr = { 800.4f, 11, 50, 771, 649, 770, 240, 9 };
            int[] arr2 = { 800, 1, 5, 71, 49, -10, 40, -29 };



            SelectionSortG.Sort(arr);
            SelectionSortG.Sort(arr2);

            //SelectionSortG.SelectionSort(arr, arr.Length);
            //SelectionSortG.SelectionSort(arr2, arr2.Length);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "\n");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr2[i] + "\n");
        }
    }
}

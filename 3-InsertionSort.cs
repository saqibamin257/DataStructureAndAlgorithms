using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class InsertionSort_Result
    {
        public static void InsertionSort()
        {
            int[] arr = new int[] { 12, 11, 13, 5, 6 };
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int key = arr[i];
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            PrintArrayElements(arr);
        }

        internal static void PrintArrayElements(int[] array)
        {
            for(int i=0; i<array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

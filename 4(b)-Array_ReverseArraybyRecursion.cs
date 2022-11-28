using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class ReverseArraybyRecursion
    {        
        internal static ArrayList  RecursiveArray(ArrayList arr,int start, int end) 
        {
            if (start >= end)
                return arr;

            var temp = arr[start];
            arr[start]= arr[end];
            arr[end]= temp;
            return RecursiveArray(arr,start+1,end-1);            
        }

        public static void Input()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //string[] arr = new string[] { "karachi","lahore","islamabad" };
            int start = 0;
            int end = arr.Length - 1;
            ArrayList result = RecursiveArray(new ArrayList(arr), start, end);
            new ReverseArraybyRecursion().PrintArray(result);
        }

        internal void PrintArray(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class ReverseArray_Solution
    {
        //Reverse of string or numeric Array.
        public void ReverseArray() 
        {
            //integer Array
            //int[] arr = new int[] {10,20,30,40,50,60,70 };
            //output 70,60,50,40,30,20,10


            //String Array
            string[] arr = new string[] {"Karachi", "Lahore","Islamabad"};

            int TotalArrayLength= arr.Length;
            int Counter = Convert.ToInt32(Math.Floor(Convert.ToDecimal(TotalArrayLength / 2)));
            int Length = TotalArrayLength - 1;

            for (int i=0;i<Counter;i++) 
            {              
                var temp = arr[i];
                arr[i]= arr[Length-i];
                arr[Length-i]= temp;
            }
            PrintArray(new ArrayList(arr));
        }
        //it can take any type of input numeric or string
        //That is why ArrayList is being used here.
        internal void PrintArray(ArrayList list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        } 
    }

   
}

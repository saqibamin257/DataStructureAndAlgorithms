using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class Stack_Result
    {
        Stack objStack = new Stack();
        public void StackOperation() 
        {
            Push();
            Peek();
            Contain();
            Pop();
        }
        private void Push() 
        {
            // Non Generic: any type of data            
            objStack.Push("saqib");
            objStack.Push("amin");
            objStack.Push(257);
            objStack.Push("karachi");

            foreach(var s in objStack) 
            {
                Console.WriteLine(s);
            }
            //output karachi,257,amin,saqib
        }
        private void Peek()
        {
            Console.WriteLine($"\nWithout removing an element - Last Element of the stack is: {objStack.Peek()}");
        }

        private void Contain() 
        {
            string name = "saqib";
            if (objStack.Contains(name)) 
            {
                Console.WriteLine($"\nStack contains element:{name}");
            }
            else 
            {
                Console.WriteLine($"\nStack doesn't contains element:{name}");
            }
        }
        private void Pop() 
        {
            Console.WriteLine($"\nOriginal Stack element count are: {objStack.Count}");            
            Console.WriteLine($"\nPop element:{objStack.Pop()}");
            Console.WriteLine($"\nAfter Pop(remove) one element from stack, total element counts are: {objStack.Count}");
        }
    }
}

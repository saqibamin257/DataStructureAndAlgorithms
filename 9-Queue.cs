using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class Queue_Result
    {
        Queue my_queue = new Queue(); // Non generic queue
        public void QueueOperations() 
        {
            Add();
            Console.WriteLine($"\nInitially Total number of Elements in the Queue are :{my_queue.Count}");
            PrintQueueData();
            Peek();
            Remove();
            Console.WriteLine($"\nAfter removing one element, Total number of Elements in the Queue are :{my_queue.Count}");
            string name = "amin";
            if (my_queue.Contains(name)) 
            {
                Console.WriteLine($"\nQueue contains element: {name}");
            }
            else 
            {
                Console.WriteLine($"\nQueue does not contains element: {name}");
            }
            my_queue.Clear();
            Console.WriteLine($"\nAfter clearing Queue,Total number of Elements in the Queue are :{my_queue.Count}");
        }

        private void Add() 
        {
            my_queue.Enqueue("saqib");
            my_queue.Enqueue("amin");
            my_queue.Enqueue("257");
            my_queue.Enqueue(null);
            my_queue.Enqueue("karachi");
        }
        private void PrintQueueData()
        {
            foreach(var q in my_queue) 
            {
                Console.WriteLine(q);
            }
        }
        private void Peek() 
        {
            Console.WriteLine($"\nPeek element of Queue is : {my_queue.Peek()}");
        }
        private void Remove() 
        {
            my_queue.Dequeue();
        }
        private bool Contains(string str) 
        {
            return my_queue.Contains(str) ? true : false;
        }
        private void Clear() 
        {
            my_queue.Clear();
        }
    }
}

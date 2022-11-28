using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class SingleLinkList_Result
    {
        public Node head;
        public class Node 
        {
           public int data;
           public Node next;
            public Node(int d) 
            {
                data = d;
                next = null;
            }
        }
        //function to print node data of linklist
        internal void PrintNodeData(Node n) 
        {
            while(n!= null) 
            {
                Console.WriteLine($" {n.data}");
                n = n.next;
            }
        }
    }

    public class SingleLinkList_Solution 
    {       
        public void Input() 
        {
            // assign data values to each node
            SingleLinkList_Result SingleList = new SingleLinkList_Result();
            SingleList.head = new SingleLinkList_Result.Node(1);
            SingleLinkList_Result.Node second = new SingleLinkList_Result.Node(2);
            SingleLinkList_Result.Node third = new SingleLinkList_Result.Node(3);

            //connect each node with eachother via next. head ------>second ------> third

            SingleList.head.next = second;
            second.next= third;

            //print Link List Node Data
            new SingleLinkList_Result().PrintNodeData(SingleList.head);
        }
        
    }
}

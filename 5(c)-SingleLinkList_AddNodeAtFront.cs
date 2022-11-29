using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class SingleLinkList_AddNodeAtFront
    {
        public SingleLinkList LList = new SingleLinkList();
        public void CreateInitialNodes() 
        {           
            LList.head = new SingleLinkList.Node(2);
            SingleLinkList.Node second = new SingleLinkList.Node(3);
            SingleLinkList.Node third = new SingleLinkList.Node(4);

            //Connect each node with other
            LList.head.next = second;
            second.next = third;

            //Print intial LinkList data
            Console.WriteLine($"-------Initial 3 Nodes------");
            PrintNodeData(LList.head);

            //insert new data at front
            SingleLinkList.Node new_Node = Push(1, LList.head);

            //Print LinkList after insertion
            Console.WriteLine($"\n------After inserting new node at front------");
            PrintNodeData(new_Node);

        }

        //Print Node Data
        public void PrintNodeData(SingleLinkList.Node n)
        {
            while (n != null)
            {
                Console.Write($" {n.data}");
                n = n.next;
            }
        }
        //function to push new node at front
        public SingleLinkList.Node Push(int new_data, SingleLinkList.Node head) 
        {
            SingleLinkList.Node new_node = new SingleLinkList.Node(new_data);            
            new_node.next = head;            
            return new_node;
        }
    }

    public class SingleLinkList 
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
    }
}

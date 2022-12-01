using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class DSA_SingleLinkedList
    {
        public Node head;
        public class Node 
        {
            public int data;
            public Node next;            
            //constructor
            public Node (int d) 
            {
                data= d;
                next = null;
            }
        }
        //Insert data at front, at start.
        public void push(int new_data) 
        {
            Node new_node = new Node (new_data);
            new_node.next = head;
            head = new_node;
        }
        
        /* Inserts a new node after the given prev_node. */
        public void InsertAfter(Node prev_node,int new_data) 
        {
            /* 1. Check if the given Node is null */
            if(prev_node == null) 
            {
                Console.WriteLine("The given previous" +
                              " node cannot be null");
                return;
            }
            /* 2 & 3: Allocate the Node &
                Put in the data*/
            Node new_node = new Node (new_data);
            prev_node.next = new_node;
        }

        /* Appends a new node at the end. This method is
           defined inside LinkedList class shown above */
        public void append(int new_data) 
        {
            /* 1. Allocate the Node &
               2. Put in the data
               3. Set next as null */
            
            Node new_node = new Node(new_data);
            
            /* 4. If the Linked List is empty,
                 then make the new node as head */

            if( head == null) 
            {
                head = new Node (new_data);
                return;
            }

            /* 4. This new node is going to be the last node,
               so make next of it as null */
            new_node.next = null;

            /* 5. Else traverse till the last node */
            Node last = head;

            while(last.next != null) 
            {
                last = last.next;
            }
            last.next = new_node;
            return;
        }

        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class LinkedList_Result
    {
        public Node head; // head of list
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
    public class LinkedList_Solution
    {
        public void Input()
        {
            //Create Node
            LinkedList_Result IList = new LinkedList_Result();
            IList.head = new LinkedList_Result.Node(1);
            LinkedList_Result.Node second = new LinkedList_Result.Node(2);
            LinkedList_Result.Node third = new LinkedList_Result.Node(3);

            /* Three nodes have been allocated dynamically.
               We have references to these three blocks as head,
                second and third

                llist.head     second             third
                    |             |                 |
                    |             |                 |
                +----+------+     +----+------+     +----+------+
                | 1 | null |     | 2 | null |     | 3 | null |
                +----+------+     +----+------+     +----+------+ */

            //Now
            // Link first node with the second node
            IList.head.next = second;

            // Link second node with the third node
            second.next = third;

            /* Now next of the second Node refers to third. So
               all three nodes are linked.

               llist.head     second             third
                   |             |                 |
                   |             |                 |
               +----+------+     +----+------+     +----+------+
               | 1 | o-------->| 2 | o-------->| 3 | null |
               +----+------+     +----+------+     +----+------+ */
        }
    }
}

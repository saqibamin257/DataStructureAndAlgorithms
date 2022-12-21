using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class BInaryTree_Insertion_LevelOrder
    {
        public Node root;
        public class Node 
        {
           public int key;
           public Node left, right;
            public Node(int item) 
            {
                key = item;
                left = right = null;
            }
        }
        /* Inorder traversal of a binary tree*/
        public void InOrder(Node temp) //left-current-right
        {
            if (temp != null) 
            {
                InOrder(temp.left);
                Console.Write(temp.key + " ");
                InOrder(temp.right);
            }
        }

        /* PreOrder traversal of a binary tree*/  

        public void PreOrder(Node temp) //current-left-right
        {
            if(temp != null) 
            {
                Console.Write(temp.key + " ");
                PreOrder(temp.left);
                PreOrder(temp.right);
            }
        }

        /* PostOrder traversal of a binary tree*/

        public void PostOrder(Node temp) //left-right-current
        {
            if (temp != null)
            {
                PostOrder(temp.left);
                PostOrder(temp.right);
                Console.Write(temp.key + " ");
            }
        }



        /*function to insert element in binary tree */
        public void Insert(Node temp, int key)
        {
            if (temp == null)
            {
                root = new Node(key);
                return;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);

            // Do level order traversal until we find an empty place.

            while (q.Count != 0) 
            {
                temp = q.Peek();
                q.Dequeue();

                if(temp.left == null)
                {
                    temp.left = new Node(key);
                    break;
                }
                else 
                {
                    q.Enqueue(temp.left);
                }

                if (temp.right == null)
                {
                    temp.right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.right);
            }
        }
    }
    public class BinaryTree_Insertion_Solution 
    {
        public void Input() 
        {
            BInaryTree_Insertion_LevelOrder objBinary = new BInaryTree_Insertion_LevelOrder();
            objBinary.root = new BInaryTree_Insertion_LevelOrder.Node(10);
            objBinary.root.left = new BInaryTree_Insertion_LevelOrder.Node(11);
            objBinary.root.left.left = new BInaryTree_Insertion_LevelOrder.Node(7);
            objBinary.root.right = new BInaryTree_Insertion_LevelOrder.Node(9);
            objBinary.root.right.left = new BInaryTree_Insertion_LevelOrder.Node(15);
            objBinary.root.right.right = new BInaryTree_Insertion_LevelOrder.Node(8);

            /* Tree
                     10
                    /  \
                   11   9
                  / \  / \
                 7     15 8     */

            Console.Write("\nInorder traversal before insertion:");
            objBinary.InOrder(objBinary.root);

            int key = 12;
            objBinary.Insert(objBinary.root, key);

            Console.Write("\nInorder traversal after insertion:");
            objBinary.InOrder(objBinary.root);
        }
    }
}

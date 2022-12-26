using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class BinarySearchTree_Searching
    {
        public Node root;
        public class Node 
        {
           public int key;
           public Node left, right;
            public Node(int value) 
            {
                key = value;
            }
        }
        public Node BSTSearch(Node root, int key)
        {
            //Base case
            //if root == null or root.key == key.

            if (root == null || key == root.key) 
            {
                return root;
            }
            //if key is smaller than root.key
            if (key < root.key) 
            {
                return BSTSearch(root.left,key);
            }          
            //if key is greater than root.key
                return BSTSearch(root.right,key);
        }
        public void Input() 
        {
            //   /* Let us create following BST
            //              50
            //           /     \
            //          30      70
            //         /  \    /  \
            //       20   40  60   80 */
            
            root = new Node(50);
           
            root.left = new Node(30);
            root.left.left = new Node(20);
            root.left.right = new Node(40);

            root.right = new Node(70);
            root.right.left = new Node(60);
            root.right.right = new Node(80);

            //if exists show Exists else Not Exists
            int key = 40;
            Node result = new BinarySearchTree_Searching().BSTSearch(root,key);
            if(result.key == key)
            {
                Console.WriteLine($"{key} Exists in the Binary Tree!");
            }
            else 
            {
                Console.WriteLine($"{key} Not Exists in the Binary Tree!");
            }
        }
    }
}

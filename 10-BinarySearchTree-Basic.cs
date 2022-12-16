using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    
    public class BinaryTree
    {
        Node root;
        public BinaryTree(int item) { root = new Node(item); }
        public BinaryTree() { root = null; }

        public class Node
        {
            int key;
            public Node left, right;
            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        public void Input()
        {
            BinaryTree tree = new BinaryTree();
            //create root
            tree.root = new Node(1);
            /* Following is the tree after above statement
               1
              / \
            null null */

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
    
            /* 2 and 3 become left and right children of 1
                     1
                    / \
                   2   3
                  / \ / \
            null null null null */
            tree.root.left.left= new Node(4);

            /* 4 becomes left child of 2
                       1
                      / \
                     2   3
                    / \ / \
                 4 null null null
                   / \
                null null
            */


        }
    }
}

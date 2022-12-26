using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    //public class Node
    //{
    //    public int key;
    //    public Node left, right;
    //    public Node(int item)
    //    {
    //        key = item;
    //        left = right = null;
    //    }
    //}
    //public class BinarySearchTree
    //{
    //    // root Node
    //    public Node root;
    //    //constructor
    //    public BinarySearchTree() 
    //    {
    //        root = null;
    //    }
    //    public BinarySearchTree(int value) 
    //    {
    //        root = new Node(value);
    //    }
    //    // This method mainly calls insertRec()
    //   public void Insert(int key) 
    //    {
    //        root = InsertRec(root, key);
    //    }

    //    // A recursive function to insert a new key in BST
    //    public Node InsertRec(Node root, int key) 
    //    {
    //        // If the tree is empty, return a new node
    //        if (root == null)
    //        {
    //            root = new Node(key);
    //            return root;
    //        }
    //        else if (key < root.key) 
    //        {
    //            root.left = InsertRec(root.left, key);
    //        }
    //        else if(key > root.key) 
    //        {
    //            root.right=InsertRec(root.right, key);
    //        }
    //        return root;
    //    }
    //    //This method mainly calls InOrderRec()
    //   public void InOrder() 
    //    {
    //        InOrderRec(root);
    //    }
    //    // A utility function to do inorder traversal of BST

    //    public void InOrderRec(Node root) 
    //    {
    //        if (root != null) 
    //        {
    //            InOrderRec(root.left);
    //            Console.Write(root.key + " ");
    //            InOrderRec(root.right);
    //        }
    //    }
    //}

    //public class BinarySearchTree_Solution
    //{
    //    public void Input() 
    //    {
    //        BinarySearchTree tree = new BinarySearchTree();
    //        /* Let us create following BST
    //              50
    //           /     \
    //          30      70
    //         /  \    /  \
    //       20   40  60   80 */

    //        tree.Insert(50);
    //        tree.Insert(30);
    //        tree.Insert(20);
    //        tree.Insert(40);
    //        tree.Insert(70);
    //        tree.Insert(60);
    //        tree.Insert(80);
            
    //        // Print inorder traversal of the BST
    //        tree.InOrder();

    //    }

    //}
    public class Node 
    {
        public int Key;
        public Node left, right;
        public Node(int item) 
        {
            Key = item;
            left = right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree() 
        {
            root = null;
        }
        public BinarySearchTree(int key) 
        {
            root = new Node(key);
        }
        public void Insert(int key) 
        {
            root = InsertNode(root, key);
        }
        public Node InsertNode(Node root,int key) 
        {
            if (root == null) 
            {
                root = new Node(key);
                return root;
            }
           else if(key < root.Key) 
            {
                root.left = InsertNode(root.left, key);               
            }
            else if (key > root.Key)
            {
                root.right = InsertNode(root.right, key);
            }
            return root;            
        }
        public void PrintInOrder() 
        {
            InOrder(root);
        }
        public void InOrder(Node root) 
        {
            if (root != null) 
            {
                //left-center-right
                InOrder(root.left);
                Console.Write($"{root.Key} ");
                InOrder(root.right);
            }            
        }
    }
    public class BinarySearchTree_Solution 
    {
        public void Input() 
        {
            BinarySearchTree tree = new BinarySearchTree();
            //   /* Let us create following BST
            //              50
            //           /     \
            //          30      70
            //         /  \    /  \
            //       20   40  60   80 */

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // Print inorder traversal of the BST
            tree.PrintInOrder();
            //output 20 30 40 50 60 70 80
            
        }
    }


}

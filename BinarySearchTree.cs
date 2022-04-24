// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
namespace binarySearchTree
{
    public class binarySearchTree
    {
        public class Node 
        {
            public Node leftNode;
            public Node rightNode;
            public int data;
            
            public void DisplayNode()
            {
                Console.Write(data + " ");
            }
                
            public Node(int value)//constructor
            {
                this.leftNode = null;
                this.rightNode = null;
                this.data = value;
            }
        }
        
        public Node root;
        
        public binarySearchTree() //constructor
        {
            this.root = null;
        }
        
        public void insert(int value) //
        {
            //create the new node
            Node newNode = new Node(value);
            newNode.data = value;
            //check if tree is empty, if so, add new node as root node
            if (this.root == null)
            {
                this.root = newNode;
            }
            
            //else, if there are existing nodes
            
        }
        
        //public void lookup(int data) {}
    
        public static void Main(string[] args)
        {
            binarySearchTree tree = new binarySearchTree();
            tree.insert(9);
            //tree.insert(4)
            //tree.insert(6)
            //tree.insert(20)
            //tree.insert(170)
            //tree.insert(15)
            //tree.insert(1)
        }
        
        //public binarySearchTree traverse(node) 
        //{
            // tree = new binarySearchTree();
            //tree = ( value, node.value );
            // condition ? consequent : alternative
            //tree.left = node.left == null ? null : traverse(node.left);
            //tree.right = node.right == null ? null : traverse(node.right);
            //return tree;
        //}
    }

}

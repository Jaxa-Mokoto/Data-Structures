using System;

class Node
{
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
    public int Data { get; set; }
}

class BinaryTree
{
    public Node Root { get; set; }
 
    public bool Insert(int value)
    {
        Node newNode = new Node();
        newNode.Data = value;
        
        if (this.Root == null)//Tree is empty
            this.Root = newNode;
        
        else
        { 
            Node currentNode = new Node();
            currentNode = this.Root; 
            while (true)
            {
                if (value < currentNode.Data) //Is new node in left tree? 
                {
                    if (currentNode.LeftNode == null)
                    {
                        currentNode.LeftNode = newNode;
                    }
                    currentNode = currentNode.LeftNode; // if there is something on the RightNode
                }
                
                if (value > currentNode.Data) //Is new node in right tree?
                {
                    if (currentNode.RightNode == null)
                    {
                        currentNode.RightNode = newNode;
                    }
                    currentNode = currentNode.RightNode;  // if there is something on the RightNode
                }
                else 
                {
                    return false;
                }
            }
        }
        return true;
    }
 
    public Node Find(int value)
    {
        return this.Find(value, this.Root);            
    }
 
    public void Remove(int value)
    {
        this.Root = Remove(this.Root, value);
    }
 
    private Node Remove(Node parent, int key)
    {
        if (parent == null) return parent;
 
        if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key); 
        else if (key > parent.Data)
            parent.RightNode = Remove(parent.RightNode, key);
 
        // if value is same as parent's value, then this is the node to be deleted  
        else
        {
            // node with only one child or no child  
            if (parent.LeftNode == null)
                return parent.RightNode;
            else if (parent.RightNode == null)
                return parent.LeftNode;
 
            // node with two children: Get the inorder successor (smallest in the right subtree)  
            parent.Data = MinValue(parent.RightNode);
 
            // Delete the inorder successor  
            parent.RightNode = Remove(parent.RightNode, parent.Data);
        }
 
        return parent;
    }
 
    private int MinValue(Node node)
    {
        int minv = node.Data;
 
        while (node.LeftNode != null)
        {
            minv = node.LeftNode.Data;
            node = node.LeftNode;
        }
 
        return minv;
    }
 
    private Node Find(int value, Node parent)
    {
        if (parent != null)
        {
            if (value == parent.Data) return parent;
            if (value < parent.Data)
                return Find(value, parent.LeftNode);
            else
                return Find(value, parent.RightNode);
        }
 
        return null;
    }
 
    public int GetTreeDepth()
    {
        return this.GetTreeDepth(this.Root);
    }
 
    private int GetTreeDepth(Node parent)
    {
        return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
    }
 
    public void TraversePreOrder(Node parent)
    {
        if (parent != null)
        {
            Console.Write(parent.Data + " ");
            TraversePreOrder(parent.LeftNode);
            TraversePreOrder(parent.RightNode);
        }
    }
 
    public void TraverseInOrder(Node parent)
    {
        if (parent != null)
        {
            TraverseInOrder(parent.LeftNode);
            Console.Write(parent.Data + " ");
            TraverseInOrder(parent.RightNode);
        }
    }
 
    public void TraversePostOrder(Node parent)
    {
        if (parent != null)
        {
            TraversePostOrder(parent.LeftNode);
            TraversePostOrder(parent.RightNode);
            Console.Write(parent.Data + " ");
        }
    }
}

class MainClass {
    static void Main() 
    {
        BinaryTree binaryTree = new BinaryTree();
         
        binaryTree.Insert(1);
        binaryTree.Insert(2);
        binaryTree.Insert(7);
        binaryTree.Insert(3);
        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(89);
         
        Node node = binaryTree.Find(5);
        int depth = binaryTree.GetTreeDepth();
         
        Console.WriteLine("PreOrder Traversal:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine(" \n");
         
        Console.WriteLine("InOrder Traversal:");
        binaryTree.TraverseInOrder(binaryTree.Root);
        Console.WriteLine(" \n");
         
        Console.WriteLine("PostOrder Traversal:");
        binaryTree.TraversePostOrder(binaryTree.Root);
        Console.WriteLine(" \n");
         
        binaryTree.Remove(7);
        binaryTree.Remove(8);
         
        Console.WriteLine("PreOrder Traversal After Removing Operation:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();
    }
}
 

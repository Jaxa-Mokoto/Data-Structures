//--------------------------------------------------------------------
// This is converting the singly linked list to a doubly linked list
//--------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    //Example Structure of a linked list

    // [5]
    // 456 --> [7]
    //         662 --> [8]
    //                 555

    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode prev;

        // Now create a constructor that will take in node value and set
        public LinkedListNode(int value)
        {
            data = value;
            next = null; // This indicates that we have reached the end of the node
            prev = null; // This is the birth of a doubly linked list as this property indicates the previous node in the list
        }
    }

    public class LinkedList
    {
        // This node will help us keep track of the beginning of the linked list
        LinkedListNode head;

        // Counter to keep track of how many items are in the linked list
        int numberOfElementsInLinkedList;

        //constuctor to enure that the head node is null
        public void MyLinkedList()
        {
            head = null;
            numberOfElementsInLinkedList = 0;
        }
        // method to help us add new nodes to the front
        public void AddNodeToFront(int data)
        {
            //Create the new node
            LinkedListNode node = new LinkedListNode(data);

            //Add data to the front of the linked list
            node.next = head;
            head = node; // add reference to the new node i.e. pointer
            numberOfElementsInLinkedList++;
        }
        
        // method to add to the end of a linked list
        public void AppendLinkedList(int data) 
        {
              //1. allocate node
            LinkedListNode node = new LinkedListNode(data);
              
              //2. assign data element
              node.data = data;
              
              //3. assign null to the next of new node
              node.next = null; 
              
              //4. Check the Linked List is empty or not,
              //   if empty make the new node as head
              if(head == null) {
                head = node;
              } 
              else 
              {
                //5. Else, traverse to the last node
                LinkedListNode temp = new LinkedListNode(data);
                temp = head;
                
                while(temp.next != null)
                  temp = temp.next;
                  numberOfElementsInLinkedList++; 
                
                //6. Change the next of last node to new node
                temp.next = node;
                temp.prev =  TraverseToIndex(numberOfElementsInLinkedList-1);
              }
        }
        
        // Method to insert into linked list with a given value and index to insert at
        public void Insert(int index, int value) 
        {
            //check values (validation - check if index is to the end of the list)
            if (index > numberOfElementsInLinkedList)
            {
                AppendLinkedList(value);
            }
            
            // Create a new node
            LinkedListNode newNode = new LinkedListNode(value);
            
            // Now to traverse to the leading node (the node just before the one to insert to "index -1")
            var leadNode = TraverseToIndex(index-1);
            
            // Now hold a pointer for the pushed back node
            var pushedPointer = leadNode.next;
            
            // Next, create a pointer for the new node
            leadNode.next = newNode;
            
            // Now, create a pointer from the new node to reference the pushed node
            // i.e (leadNode)  *     * (pushed back pointer)
            //                  \  /
            //                   *
            //                (newNode)
            newNode.next = pushedPointer;
            numberOfElementsInLinkedList++;
            newNode.prev =  TraverseToIndex(numberOfElementsInLinkedList-1);
        }
        
        // Method to remove items from linked list wit a given index
        public void Remove(int index) 
        {
            // Validate params (skipped..)
            
            // Get the leading node (node before the one to delete
            var leadNode = TraverseToIndex(index-1);
            
            // Get the node to remove
            var nodeToRemove = leadNode.next;
            
            // Get the deleted node's pointer
            var disconnectedPointer = nodeToRemove.next;
                      
            // Reset pointer
            leadNode.next = disconnectedPointer;
            numberOfElementsInLinkedList--;
            leadNode.prev =  TraverseToIndex(numberOfElementsInLinkedList-1);
        }
        
        // Method to traverse through the linked list to the desired index
        public LinkedListNode TraverseToIndex(int index)
        {
            //check params (skipped..)
            
            int counter = 0;
            LinkedListNode currentNode = head;
            
            while(counter != index) //until we have reached the desired node, skip and go to the next node
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

        // Simple method to print all items in the linked list
        public void PrintList()
        {
            //This is an indicator of where the front of the linked list is
            LinkedListNode runner = head;
            // Must check if the current data is not null prior to accessing the data
            while (runner != null)
            {
                Console.WriteLine($"My Linked List contains: {runner.data}");

                // goes to the next item to print out
                runner = runner.next;
            }
        }
    }

    public static void Main(string[] args)
    {
        // Instantiating the linked list
        LinkedList myLinkedList = new LinkedList();

        // Add new elements to the linked list
        myLinkedList.AddNodeToFront(2);
        myLinkedList.AddNodeToFront(23);
        myLinkedList.AddNodeToFront(4);
        myLinkedList.AddNodeToFront(55);
        myLinkedList.AddNodeToFront(6);
        myLinkedList.AddNodeToFront(78);
        myLinkedList.AddNodeToFront(78);
        myLinkedList.AddNodeToFront(55);
        
        myLinkedList.AppendLinkedList(36);
        myLinkedList.Insert(2, 222);
        myLinkedList.Remove(1);
        myLinkedList.PrintList();
    }
}

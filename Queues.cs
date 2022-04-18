//--------------------------------------------------------------------------
// Examples containing how to queue(value), enqueue() & peek()
//--------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class linkedListNode 
    {
        public string value;
        public linkedListNode next;
        
        public linkedListNode(string data) // constructor
        {
           value = data;
           next = null;
        }
    }
    
    public class Queue 
    {
        public linkedListNode first;
        public linkedListNode last;
        public int length;
        
        public Queue() 
        {
            first = null;
            last = null;
            length = 0;
        }
        // example (FIRST) Tim <- John <- Peter <- Naomi <- Jane (LAST)
        
        public void peek()
        {
            Console.WriteLine($"First item in Queue is..  {first.value}");
        }
        
        public void enqueue(string value) // adds to queue in FIFO 
        {
            // Instantiate the new node
            linkedListNode newNode = new linkedListNode(value);
            
            // Validate if this is linked list is populated
            if (length == 0)
            {
                first = newNode;
                last = newNode;
            }
            
            else
            {
                last.next = newNode;
                last = newNode;
            }
            
            length++;
        }
        
        public void dequeue() //remove items from list in FIFO
        {
            // validate if no items are in queue
            if (length == 0)
            {
               Console.WriteLine("Nothing to remove... try adding items first");
            }
            
            // validate if only item in queue
            if (first == last)
            {
                last = null;
            }
            
            // If not, reset the queue order to remove the first item/person  in the queue
            var holdingPointer = first; // reference for pointer if needed (garbage collection)
            first = first.next;
            length--;
        }
        
        public void printQueue() 
        {
            linkedListNode runner = first;

            while(runner.value != null)
            {
                Console.WriteLine(runner.value);
                runner = runner.next;
            }
        }
        
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate 
            Queue myQueue = new Queue();
            
            // example (FIRST) Tim <- John <- Peter <- Naomi <- Jane (LAST)
            myQueue.enqueue("tim");
            myQueue.enqueue("john");
            myQueue.enqueue("peter");
            myQueue.enqueue("naomi");
            
            myQueue.dequeue();
            
            myQueue.peek();
            
            myQueue.printQueue();
                
            
            
        }
    }
}

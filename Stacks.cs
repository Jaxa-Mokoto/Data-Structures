//--------------------------------------------------------------------
// Contains examples on how to Pop(), Push() and Peek() from stack
//--------------------------------------------------------------------

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
    
    public class Stack 
    {
        public linkedListNode top;
        public linkedListNode bottom;
        public int length;
        
        public Stack() 
        {
            top = null;
            bottom = null;
            length = 0;
        }
        
        public void peek()
        {
            Console.WriteLine($"Top item in Stack is..  {top.value}");
        }
        
        public void push(string value) 
        {
            // Instantiate the new node
            linkedListNode newNode = new linkedListNode(value);
            
            // Validate if this is linked list is populated
            if (length == 0)
            {
                top = newNode;
                bottom = newNode;
            }
            
            else
            {
                linkedListNode holdingPointer = top;
                top = newNode;
                top.next = holdingPointer;
            }
            length++;
        }
        
        public void pop()
        {
            // validate if no items are in stack
            if (length == 0)
            {
               Console.WriteLine("Nothing to remove... try adding items first");
            }
            // validate if only item in stack
            if (top == bottom)
            {
                top = null;
            }
            
            // If not, reset the stack order
            var holdingPointer = top;
            top = top.next;
            length--;
        }
        
        public void printStack() 
        {
            linkedListNode runner = top;
            
            while(runner != null)
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
            Stack myStack = new Stack();
            
            myStack.push("Google");
            myStack.push("Amazon");
            myStack.push("Facebook");
            
            ///myStack.pop();
            
            myStack.peek();
            
            myStack.printStack();
                
            
            
        }
    }
}

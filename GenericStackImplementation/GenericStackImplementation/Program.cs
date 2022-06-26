using System;
using System.Collections.Generic;

namespace GenericStackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack is a data structure that represents a last-in-first-out (LIFO) algorithm
            Stack<string> myStack = new Stack<string>();
            //The push() method is use to insert an item into the stack
            myStack.Push("C#");
            myStack.Push("Docker");
            myStack.Push("SQL Server");
            myStack.Push("JavaScript");

            Console.WriteLine("My stack list...............");
            foreach(string obj in myStack)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("......................");
            // Calling the pop() method removes an item from the top of the stack
            Console.WriteLine("Popping = {0}", myStack.Pop());
            foreach (string obj in myStack)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("......................");
            // Peek() method returns an item at the top of the stack but does not remove it from the stack.
            Console.WriteLine("Peeking = {0}", myStack.Peek());
            foreach (string obj in myStack)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(".......................");
            // To print a stack as array create a copy of the stack using ToArray()  method
            Stack<string> myStackCopy = new Stack<string>(myStack.ToArray());
            Console.WriteLine("Contents of the first copy");
            foreach (string obj in myStackCopy)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("......................");
            // Create an array twice the size of the stack and copy the element of the stack
            string[] array = new string[myStack.Count * 2];
            myStack.CopyTo(array, myStack.Count);

            // Create a second stack
            Stack<string> myStackCopy2 = new Stack<string>(array);
            Console.WriteLine("Contents of the second copy");
            foreach (string obj in myStackCopy2)
            {
                Console.WriteLine(obj);
            }
            // Call the Contains() method
            Console.WriteLine("Does stack2 contains Java? = {0}", myStackCopy2.Contains("Java"));

            Console.Read();
            
        }
    }
}

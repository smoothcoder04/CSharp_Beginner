using System;
using System.Collections.Generic;


namespace StackQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
            mystack.Push(6);
            mystack.Push(7);
            mystack.Push(1000000);

            PrintLastPushed(mystack);
            PrintStackCount(mystack);

            var newStack = new StackBegin<int>(mystack);

            static void PrintLastPushed<T>(Stack<T> newStack)
            {
                Console.WriteLine($"Placed {newStack.Peek()} at the top of the stack");
            }

            static void PrintStackCount<T>(Stack<T> newStack)
            {
                Console.WriteLine($"There are {newStack.Count} items in the stack");
            }

            //Queue

            var customer1 = new QueueBegin() { Name = "Louie" };
            var customer2 = new QueueBegin() { Name = "Ross" };
            var customer3 = new QueueBegin() { Name = "Phoebe" };
            var customer4 = new QueueBegin() { Name = "Mithu" };

            var myQueue = new Queue<QueueBegin>();
            myQueue.Enqueue(customer1);
            myQueue.Enqueue(customer2);
            myQueue.Enqueue(customer3);
            myQueue.Enqueue(customer4);

            while (myQueue.Count > 0)
            {
                Console.WriteLine($"Next customer in line is {myQueue.Peek().Name}");
                Console.WriteLine($"{myQueue.Dequeue().Name} paid & left");
            }


        }
    }
}
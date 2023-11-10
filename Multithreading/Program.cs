using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets the current thread
            var thread = Thread.CurrentThread;

            //Set the name property of the thread
            thread.Name = "Main thread";
            Console.WriteLine($"Name of the thread = {thread.Name}");
            Console.WriteLine($"Thread id = {thread.ManagedThreadId}");
            Console.WriteLine($"Check thread is alive = {thread.IsAlive}");
            Console.WriteLine($"Thread is running in the background = {thread.IsBackground}");
            Console.WriteLine($"Thread Priority = {thread.Priority}");
            Console.WriteLine($"Thread state = {thread.ThreadState}");

        }
    }
}
using System;
using System.Threading;

namespace CreatingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Mithu's thread";
            var threadStart = new ThreadStart(PrintHelloWorld);
            var thread = new Thread(threadStart);
            var thread2 = new Thread(Inform);
            thread2.Name = "2nd thread";
            var thread3 = new Thread(() =>
            {
                Console.WriteLine("Hello from anonym,ous method");
            });

            thread.Start();
            thread2.Start();
            thread3.Start();
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void Inform()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"I am executing from {Thread.CurrentThread.Name}");
            }
        }

    }

}
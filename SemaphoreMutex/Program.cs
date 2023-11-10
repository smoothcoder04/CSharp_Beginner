using System;
using System.Threading;

namespace SynchronisingThreads
{
    class Program
    {
        static string text = "Microsoft";
        static Semaphore semaphore = new Semaphore(1, 1);
        static void Main(string[] args)
        {

            var thread = new Thread(InsertNumber);
            var thread2 = new Thread(InsertNumber);
            var thread3 = new Thread(InsertNumber);

            thread.Start(1);
            thread2.Start(11);
            thread3.Start(111);


        }
        static void InsertNumber(object number)
        {
            if (number is int)
            {
                //Mark the beginning of critical code section
                semaphore.WaitOne();
                try
                {
                    string original_text = text;
                    text = text.Insert(text.Length / 2, Convert.ToString(number));
                    Console.WriteLine(text);
                    text = original_text;
                }
                finally
                {
                    semaphore.Release();
                }

            }
        }
    }
}
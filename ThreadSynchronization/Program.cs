using System;
using System.Threading;

namespace ThreadSync
{
    class Program
    {
        static string text = "Microsoft";
        //dummy object that will serve as a locker
        static object locker = new object();
        static void Main(string[] args)
        {
            var thread1 = new Thread(InsertNumber);
            var thread2 = new Thread(InsertNumber);
            var thread3 = new Thread(InsertNumber);
            var thread4 = new Thread(InsertNumber);

            thread1.Start(1);
            thread2.Start(12);
            thread3.Start(100);
            thread4.Start(200);
        }

        static void InsertNumber(object number)
        {

            if (number is int)
            {
                bool locked = false;
                Monitor.Enter(locker, ref locked);
                try
                {
                    var original = text;
                    text = text.Insert(text.Length / 2, number.ToString());
                    Console.WriteLine(text);
                    text = original;
                }
                finally
                {
                    if (locked)
                    {
                        //release lock
                        Monitor.Exit(locker);
                    }
                }

            }
        }

    }
}
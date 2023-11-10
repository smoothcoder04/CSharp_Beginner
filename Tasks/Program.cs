using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(Print);
            var task2 = Task.Run(() => { Console.WriteLine("Anonymous method inside a task"); });

            var task3 = new Task(Print);
            var task4 = new Task(() => { Console.WriteLine("2nd anonymous method"); });

            task.Wait();
            task2.Wait();

            task3.RunSynchronously();
            task4.RunSynchronously();
        }

        static void Print()
        {
            Console.WriteLine("Executing inside a task");
        }
    }
}
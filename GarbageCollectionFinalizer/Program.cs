using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateObject();
            //manually collect garbage
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
        static void CreateObject()
        {
            var course = new Course() { Title = ".NET Fundamentals" };

        }


    }
}
using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "First Object";
            string second = "Second Object";
            string third = "Third Object";
            string fourth = "Fourth Object";
            string fifth = "Fifth Object";

            //check the generation of the objects
            Console.WriteLine(GC.GetGeneration(first));
            Console.WriteLine(GC.GetGeneration(second));
            Console.WriteLine(GC.GetGeneration(third));
            Console.WriteLine(GC.GetGeneration(fourth));
            Console.WriteLine(GC.GetGeneration(fifth));

            //delete the reference to some of the objects
            second = null;
            fourth = null;

            //start garbage collection and wait till it is done
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            //check the generation that survived
            Console.WriteLine(GC.GetGeneration(first));
            Console.WriteLine(GC.GetGeneration(third));
            Console.WriteLine(GC.GetGeneration(fifth));
        }
    }
}
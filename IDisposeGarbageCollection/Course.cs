using System;

namespace GarbageCollection
{
    public class Course : IDisposable
    {
        public string Title { get; set; }

        //destructor
        ~Course()
        {
            Console.WriteLine($"The course {Title} is claimed by garbage collector");
        }
        public void Dispose()
        {
            Console.WriteLine("releasing unmanaged code...");
        }
    }
}
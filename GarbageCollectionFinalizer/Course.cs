using System;

namespace GarbageCollector
{
    public class Course
    {
        public string Title { get; set; }

        //destructor
        ~Course()
        {
            Console.WriteLine($"the title {Title} is claimed by garbage collector");
        }

    }
}
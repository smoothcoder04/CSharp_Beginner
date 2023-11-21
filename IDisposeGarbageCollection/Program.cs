using System;

namespace GarbageCollection
{
    class Program
    {
        static void Main()
        {
            Course course = null;
            try
            {
                course = new Course() { Title = "mybook" };
            }
            finally
            {
                course?.Dispose();
            }
        }
    }
}
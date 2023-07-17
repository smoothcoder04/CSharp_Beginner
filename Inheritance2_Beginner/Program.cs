using System;

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            School school = new School("My new guitar school");
            Console.WriteLine(school.Name);
        }
    }
}
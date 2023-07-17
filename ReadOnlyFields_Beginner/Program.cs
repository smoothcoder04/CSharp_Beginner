using System;

namespace ReadOnlyFields
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person(new DateTime(1990, 10, 11));
            Console.WriteLine($"Birthdate is = {person.Birthdate}");
        }
    }
}
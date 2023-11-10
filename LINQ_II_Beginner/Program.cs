using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueries
{
    class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<string>()
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD",
                "ZZZ",
                "YYY"

            };

            var noluckStudents = new List<string>()
            {
                "ZZZ",
                "AAA"
            };

            var totalpassed = students.Except(noluckStudents);

            foreach (var student in totalpassed)
            {
                Console.WriteLine(student);
            }

            //Example with intersect and union

            var noun = new List<string>()
            {
                "hill",
                "mountain",
                "grass",
                "comb",
                "drink",
                "look",
                "orbit"
            };

            var verb = new List<string>()
            {
                "look",
                "orbit",
                "hold",
                "walk"
            };

            var bothverbandnoun = noun.Union(verb);
            var verbintersectnoun = noun.Intersect(verb);

            Console.WriteLine("\n Both the list combined \n");

            foreach (var word in bothverbandnoun)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n Intersection - only the common words \n");

            foreach (var word in verbintersectnoun)
            {
                Console.WriteLine(word);
            }
        }
    }
}
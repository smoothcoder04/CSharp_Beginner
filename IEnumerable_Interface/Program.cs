using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var positiveNumbers = new PositiveIntegerList(); // initializes _positiveIntegerList
            positiveNumbers.Add(10);
            positiveNumbers.Add(230);
            positiveNumbers.Add(106);
            positiveNumbers.Add(300);
            positiveNumbers.Add(110);

            //this is how foreach works
            var enumerator = positiveNumbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            enumerator.Reset();

            //or just use foreach
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
using System;
using System.Collections;

namespace ArrayListBeginner
{
    class Program
    {
        public static void Main(string[] args)
        {
            var points = new ArrayList();
            points.Add(10);
            points.Add(20);
            points.Add(30);

            var sum = 0;
            foreach (var point in points)
            {
                sum += (int)point;
            }
            Console.WriteLine(sum);

        }
    }
}

using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var gold = new PreciousMetal(60.1m, 1);
            var silver = new PreciousMetal(30.1m, 2);

            var goldsilver = gold + silver;

            Console.WriteLine($"goldsilver is of type : {goldsilver.GetType()}");
            Console.WriteLine($"goldsilver is of type : {goldsilver.GetType().Name}");
            Console.WriteLine($"goldsilver combined value is : {goldsilver.DollaValue}");
            Console.WriteLine($"goldsilver combined weight is : {goldsilver.Weight}");

            if (gold > silver)
            {
                Console.WriteLine("Gold is more expensive than silver.");
            }
            else
            {
                Console.WriteLine("Gold is not expensive when compared to silver.");
            }
        }


    }
}

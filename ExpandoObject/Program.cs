using System;
using System.Dynamic;

namespace DynamicExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic car = new ExpandoObject();

            car.Model = "Vauxahll";
            car.Colour = "Topaz";

            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Colour: {car.Colour}");

            car.Accelerate = new Action(() => { Console.WriteLine("Accelerating"); });

            car.Accelerate();

            //delegate that returns a value
            car.GetFuelEconomy = new Func<int>(() => { return 30; });
            int mycarfueleconomy = car.GetFuelEconomy();

            Console.WriteLine($"My car's range is {mycarfueleconomy} miles per gallon");

        }
    }
}
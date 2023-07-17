using System;

namespace AbstractSample
{
    public class Program
    {
        public static void Main()
        {
            Car myCar = new Car();
            myCar.NumberofWheels();
            Console.WriteLine($"My car model is  {myCar.model}");
            //myCar.model = "Electric";
            Console.WriteLine($"My car's model is {myCar.model}");


            Cycle myCycle = new Cycle();
            myCycle.NumberofWheels();
            Console.WriteLine($"My car's model is {myCycle.model}");
            //myCar.model;
        }
    }
}
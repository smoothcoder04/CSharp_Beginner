using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Car familyCar = new Car();
            familyCar.model = "Electric";
            familyCar.year = 1990;
            familyCar.type = "UK Plug";

            Console.WriteLine($"My new Car imodel is {familyCar.model} which was built in year {familyCar.year} and is of type {familyCar.type}");
        }
    }
}

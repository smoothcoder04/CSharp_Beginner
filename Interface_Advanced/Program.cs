using System;

namespace Interface_Advanced
{
    class Program
    {
        public static void Main()
        {
            var car = new ElectricCar();
            Console.WriteLine("I have got tesla");
            Console.WriteLine("Let's drive =====@");
            //            car.Drive();
            //car.StartTheCar(15);
            //            car.TurnTheCarOff();
            //car.StartTheCar(14);
            //            car.Drive();
            //            car.TurnTheCarOff();
            car.ReceiveRemoteCommand(14);
            car.ReceiveRemoteCommand(20);
            car.ReceiveRemoteCommand(10);

            //Country example
            INumeric population = new CountryPopulation { NumberOfPeople = 500000000, Country = "India" };
            Console.WriteLine(population.ToInt32());

            CountryPopulation population2 = (CountryPopulation)population;
            Console.WriteLine(population2.NumberOfPeople);
            Console.WriteLine(population2.Country);

            //Explicit Casting for interfaces
            IConvertible currentpopulation = population as IConvertible;
            Console.WriteLine(currentpopulation.ToInt32());
        }
    }
}
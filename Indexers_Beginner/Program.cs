using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Purgeot 308");
            var fathersCar = new Car("Hundai i10");
            var sistersCar = new Car("Toyota Prius");

            var ourGarage = new Garage(myCar, fathersCar, sistersCar);

            // Garage has an indexer that accepts an integer as a parameter
            // The indexer returns an object of type Car
            // We can access its Model property
            Console.WriteLine($"Second car in our garage is {ourGarage[1].Model}");
        }
    }
}

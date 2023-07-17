using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("LS460");
            var fathersCar = new Car("LC200");
            var sistersCar = new Car("Prius");


            var ourGarage = new Garage(myCar, fathersCar, sistersCar);
            var lcInGarage = ourGarage["LC200"];
            var chevyInGarage = ourGarage["Suburban"];

            Car myCarfirst = ourGarage[0];
            Console.WriteLine($"We have a Land Cruiser: {lcInGarage}.");
            Console.WriteLine($"We have a Chevy: {chevyInGarage}.");
            Console.WriteLine($"Mycar: {ourGarage[0].Model}");

        }

    }
}
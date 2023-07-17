using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new Car object
            Vehicle myCar = new Car();
            Vehicle husbandDrives = new Motorcycle();

            myCar.Model = "Electric and shiny new";
            husbandDrives.Model = "Old and screechy motorbike:)";

            Console.WriteLine($"I love my husband who drives {husbandDrives.Model}. i on the other hand drive {myCar.Model}");
            Console.WriteLine(myCar.Equals(husbandDrives));
            Console.WriteLine(myCar.GetHashCode());
            Console.WriteLine(myCar.GetType());
            Console.WriteLine(myCar.ToString());
        }
    }
}
using System;

namespace AbstractSample
{
    public class Car : Vehicle
    {
        //Car constructor
        public Car()
        {
            model = "Electric";
        }
        public override void NumberofWheels()
        {
            Console.WriteLine("You are inside NumberofWheels methos inside CAR abstract method");
        }
    }
}
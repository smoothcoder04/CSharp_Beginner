using System;

namespace AbstractSample
{
    public class Cycle : Vehicle
    {
        public Cycle()
        {
            model = "Light";
        }
        //abstract method
        public override void NumberofWheels()
        {
            Console.WriteLine("You are in NumberofWheels method inside Cycle");
        }
    }
}
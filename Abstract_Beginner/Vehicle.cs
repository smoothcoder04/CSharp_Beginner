using System;

namespace AbstractSample
{
    public abstract class Vehicle
    {
        //field
        public string model { get; set; }
        public int price { get; set; }

        //abstract method
        public abstract void NumberofWheels();

    }
}
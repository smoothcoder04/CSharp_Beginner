using System;

namespace GenericTypeConstraints
{
    public class Garage<T> where T : Vehicle
    {
        public T[] Vehicles { get; set; }
        public Garage(int garageSize)
        {

            Vehicles = new T[garageSize];

        }
    }
}
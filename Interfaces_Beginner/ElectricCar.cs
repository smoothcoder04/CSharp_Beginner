using System;

namespace Interfaces_Beginner
{
    public class ElectricCar : IVehicle
    {
        public int NumberOfWheels { get; } = 10;
        public void Drive()
        {
            Console.WriteLine($"Interface method implementation for Drive method ");
        }

    }
}
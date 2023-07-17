using System;

namespace GenericTypeConstraints
{
    class Program
    {
        public static void Main(string[] args)
        {
            Garage<Car> myStrangeGarage = new Garage<Car>(2);
            //Add cars in garage
            Car car1 = new Car { CarModel = "tesla" };
            Car car2 = new Car { CarModel = "BMW" };

            myStrangeGarage.Vehicles[0] = car1;
            myStrangeGarage.Vehicles[1] = car2;
            Car firstCar = myStrangeGarage.Vehicles[0];
            Car secondCar = myStrangeGarage.Vehicles[1];
            Console.WriteLine($"My Garage has {myStrangeGarage.Vehicles}. \n 2nd car is {secondCar.CarModel}");

        }
    }
}
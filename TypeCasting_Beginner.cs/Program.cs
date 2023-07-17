namespace Typecast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inside main function");
            Car mycar = new Car();
            //Vehicle myvehicle = mycar;
            Vehicle myvehicle = new Car(); //upcast
            Car someCar = (Car)myvehicle; //downcast
            Motorcycle RossVehicle = new Motorcycle();
            Vehicle RossDrive = RossVehicle;
            //Car RossCar = (Car)RossDrive;
            Car RossCar = RossDrive as Car;
            if (RossCar == null) 
            {
                Console.WriteLine("Cast failed because myVehicle points to Motorcycle object.");
            }
            else
            {
                Console.WriteLine("Cast successful.");
            }

            Car LouieCar = new Car();
            Vehicle DogVehicle = LouieCar;
            Motorcycle LouieBike = (Motorcycle)LouieCar;
            Console.WriteLine($"LouieBike  - {LouieBike.NumberOfSeatbelts}");
            Console.WriteLine($"Mycar variable - {mycar.NumberOfSeatbelts}");
            Console.WriteLine($"Mycar variable from vehicle but set in Motorcycle - {mycar.NumberOfWheels}");
            Console.WriteLine($"Myvehicle variable from Vehicle pointing to Car - {myvehicle.Price}");
            Console.WriteLine($"SomeCar variable accessing Car object properties - {someCar.NumberOfSeatbelts}");
            Console.WriteLine($"SomeCar variable accessing Vehicle object properties - {someCar.NumberOfWheels}");
            Console.WriteLine($"SomeCar variable accessing Motorcycle object properties - {someCar.NumberOfWheels}");
           // Console.WriteLine($"RossCar variable accessing Motorcycle object properties - {RossCar.NumberOfWheels}");
            //Console.WriteLine($"RossCar variable accessing Car object properties - {RossCar.NumberOfSeatbelts}");

            //Console.WriteLine($"Myvehicle variable from Vehicle pointing to Car, accessing variable set in Motorcycle - {myvehicle.NumberOfSeatbelts}");
            
            



        }

    }
}
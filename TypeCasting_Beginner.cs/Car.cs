namespace Typecast
{
    public class Car : Vehicle
    {
        public int NumberOfSeatbelts { get; set; }

        public Car()
        {
            NumberOfSeatbelts = 4;
        }
    }
}
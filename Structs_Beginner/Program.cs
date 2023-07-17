using System;

namespace Structs_Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point pointing;
            //pointing.x = 10;
            //pointing.y = 20;
            //initialize Point struct with default values
            Point pointing = new Point(10, 20);

            //Console.WriteLine($"the x value is {pointing.x} & value of y is {pointing.y}");
            pointing.getCoordinates();
        }
    }


}
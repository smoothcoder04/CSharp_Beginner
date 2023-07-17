using System;

namespace Structs_Beginner
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void getCoordinates()
        {
            Console.WriteLine($"The point coordinates are {x} and {y}");
        }
    }
}
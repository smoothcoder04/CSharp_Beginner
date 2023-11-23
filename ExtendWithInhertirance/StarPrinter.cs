using System;

namespace MainProgram
{
    public class StarPrinter : Printer
    {
        public StarPrinter(string message) : base(message)
        {

        }

        public void PrintWithStars()
        {
            Console.WriteLine($"*****{Message}****");
        }

    }
}
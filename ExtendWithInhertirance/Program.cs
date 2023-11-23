using System;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            StarPrinter printer = new StarPrinter(message);

            printer.PrintWithDashes();
            printer.PrintWithStars();
        }

    }
}
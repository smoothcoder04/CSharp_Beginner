using System;

namespace MainProgram
{
    public class Printer
    {
        public string Message { get; set; }

        public Printer(string message)
        {
            this.Message = message;
        }

        public void PrintWithDashes()
        {
            Console.WriteLine($"###{Message}");
        }
    }
}
using System;

namespace Methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation MathProblem = new MathOperation();
            //Console.WriteLine($"the multiplication of 2 numbers 5 & 10 are: {MathProblem.Multiply(5, 10)}");
            var result = MathProblem.Multiply(2, 3, 4, 5, 6, 7);
            Console.WriteLine($"the mltiplication of all numbers : {result}");
        }

    }
}
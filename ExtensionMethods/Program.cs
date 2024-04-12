using System;
using CharSplit;
using Extensions;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Abc quz";
            string company = "Meta";

            //execute the method directly on the string object as if the method is defined inside the streing class
            Console.WriteLine(name.Reverse());
            Console.WriteLine(company.Reverse());

            //char split count extension method
            string mystring = "Hello Extension method. How have you been ?";
            int count = mystring.CharSplitCount();
            Console.WriteLine(count);

        }
    }
}
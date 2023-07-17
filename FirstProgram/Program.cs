using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(String[] args)
        {

            ////Console I/O
            //Console.WriteLine("Hello Mithu! about time you learn this thing!");
            //Console.WriteLine("Where do you live");
            //string useraddress = Console.ReadLine()!; //null forgiving operator- allows null value in the variable
            //Console.WriteLine($"you said you live in {useraddress}");
            //Console.WriteLine("please neter the house number -");
            //int housenumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"your house number is {housenumber}");
            ////Switch case - Condition
            //switch (housenumber)
            //{
            //case 1:
            //Console.WriteLine("Your house number is between 1-10");
            //break;
            //case 3:
            //Console.WriteLine("Your house number is 3");
            //break;
            //default:
            //Console.WriteLine("Enter a valide housenumber");
            //break;
            //
            //}
            //Console.WriteLine("Enter your street number");
            ////variable onversion
            //int streetnumber = Convert.ToInt32(Console.ReadLine());
            //string output = (streetnumber >= 3) ? "you live in wagtail close" : "you live in in mars";
            //Console.WriteLine(output);
            ////Call Get number method
            //int squarenum = Getnumber(5);
            //Console.WriteLine($"Square of 5 is {squarenum}");
            //
            ////return min & max
            //var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var minandmax = Getminandmax(numbers);
            //Console.WriteLine($"Min number is - {minandmax.Item1}");
            //Console.WriteLine($"Max number is - {minandmax.Item2}"); ;
            //
            //}
            //static int Getnumber(int num)
            //{
            //int result = num * num;
            //return result;
            //}
            //
            //static (int, int) Getminandmax(int[] num)
            //{
            //var minarr = num[0];
            //var maxarr = num[0];
            //for (int i = 0; i < num.Length; i++)
            //{
            //if (num[i] < minarr)
            //{
            //minarr = num[i];
            //}
            //if (num[i] > maxarr)
            //{
            //maxarr = num[i];
            //}
            //
            //}
            //return (minarr, maxarr);
            //
            //}
            //create a new car object, default Constructor
            Car familyCar = new Car(1995, "electric", "Ultra");
            //Assign new values to its field
            //familyCar.year = 1995;
            //familyCar.model = "electric";
            //familyCar.type = "Ultra";

            Console.WriteLine(familyCar.CarMethod());


        }

    }
}
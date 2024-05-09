using System;

namespace LambdaSample
{
    class Program
    {
        delegate int Mathop(int x, int y);
        delegate int Mynum(int x);

        delegate int IncrementNum(ref int num);

        delegate void PrintPets();
        static void Main(string[] mithu)
        {
            Mathop mymaths = (x, y) => x + y;
            Console.WriteLine(mymaths(3, 4));

            Mynum printnum = x => x + 1;
            Console.WriteLine(printnum(5));

            PrintPets Mypet1 = () => Console.WriteLine("Pet 1 is Phoebe");
            PrintPets Mypet2 = () => Console.WriteLine("Pet 2 is Louie");

            Mypet1();
            Mypet2();

            int num = 100;

            //Number increment - pass Lambda as parameter

            ModifyNumber(ref num, (ref int num) => num++);
            Console.WriteLine(num);

            static void ModifyNumber(ref int num, IncrementNum myincrement)
            {
                myincrement(ref num);
            }

            //squarenumbers
            int[] numbers = {2,3,4,5};
            var squarenumbers = numbers.Select(x => x*x);
            Console.WriteLine(string.Join(" ",squarenumbers));
        }
    }
}
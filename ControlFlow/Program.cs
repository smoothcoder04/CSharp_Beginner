using System;
using System.Linq;


namespace ControlFlow
{
    partial class MainClass
    {


        public static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("it is morning");
            else if (hour > 12 && hour < 24)
                Console.WriteLine("it is evening");


            bool tobicustomer1 = true;
            //string mobiledata;

            //if(tobicustomer)
            //    mobiledata = "5G";
            //else
            //    mobiledata = "2G";

            //Console.WriteLine(mobiledata);

            string modeldata = tobicustomer1 ? "5G" : "2G";
            Console.WriteLine(modeldata);

            //Switch Case
            var season = seasons.winter;

            switch (season)
            {
                case seasons.rain:
                case seasons.winter:
                    Console.WriteLine("Winter");
                    break;

                default:
                    Console.WriteLine("no season");
                    break;

            }

            //Exercise 1

            //Console.WriteLine("Please enter a number");
            //string inputnumb = Console.ReadLine();
            //int number = int.Parse(inputnumb);
            //var result = (number >= 1 && number <= 10) ? "Valid" : "not valid";
            //Console.WriteLine(result);

            ////Exercise 2
            //Console.WriteLine("Please enter 1st number:");
            //string a = Console.ReadLine();
            //int c = int.Parse(a);
            //Console.WriteLine("Please enter 2nd number:");
            //string b = Console.ReadLine();
            //int d = int.Parse(b);
            //var result= "";
            //var result1 = (c > d) ? result = string.Format("{0} is the largest number of the two inputs {1} & {2}",c,c,d) : result = string.Format("{0} is the largest number of the two inputs", d);
            //Console.WriteLine(result);

            //Ecercise 3
            //Console.WriteLine("enter the height of the pic");
            //string inputnumb = Console.ReadLine();
            //int height = int.Parse(inputnumb);
            //Console.WriteLine("enter the width of the pic");
            //string inputnumb = Console.ReadLine();
            //int width = int.Parse(inputnumb);
            //var portrait = (height >= 10 && width >= 20) ? "Portrait" : "Not a protrait";
            //Console.WriteLine(portrait);

            //Ecercise 4
            //Console.WriteLine("Enter the speed of your car :");
            //string inputSpeed = Console.ReadLine();
            //int speed = int.Parse(inputSpeed);
            //var limit = 60;
            //var points = 0;


            //if(speed <= limit)
            //{
            //    Console.WriteLine("Speed limit OK");
            //}
            //else
            //{
            //    if (speed > limit)
            //    {
            //        int numbpoints = (speed-limit)/5;
            //        Console.WriteLine("number of points charged to you for driving above speed limit is {0}",numbpoints);
            //    }
            //}

            //var num = 10 / 5;
            //var numb2 = 10 % 5;
            //Console.WriteLine("/ value is {0} & % value is {1}", num, numb2 );

            //while loop

            //while (true)
            //{
            //    Console.WriteLine("Enter your name : ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Echo" + input);

            //var random = new Random();
            //const int pswdlength = 10;
            //var chararray = new char[pswdlength];
            //for (var i = 0; i < pswdlength; i++)
            //    chararray[i] = (char)( 'a' + random.Next(0,12));

            //var password = chararray;
            //Console.WriteLine(chararray);

            //Exercise 1
            //var i = 0;
            ////int j = 0;
            //var numb = new int[];
            //for (var j = 0; j<100; j++)
            //{
            //    for (i = 3; i <= 100; i++)
            //    {

            //        if(i % 3 == 0)
            //        {
            //            numb[j] = i;
            //        }

            //    }

            //    Console.WriteLine(numb[j]);
            //}

            //var count = 0;
            //for (var i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}
            //Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
            //var sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number :");
            //    string numb = Console.ReadLine();
            //    //int number = int.Parse(numb);




            //    if (numb.ToLower() == "ok")
            //    {
            //        break;

            //    }
            //    sum = sum + Convert.ToInt32(numb);

            //}
            //Console.WriteLine("sum of the numbers provided by you is " + sum);

            //Exercise 3
            //Console.WriteLine("enter a number : ");
            //string input = Console.ReadLine();
            //var num = Convert.ToInt32(input);

            //int factorial = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    factorial *= i;

            //}
            ////int result = num;
            //Console.WriteLine("factorial of {0} is {1}", num, factorial);

            //Exercixe 4
            //var secret = 7;
            //var random = new Random();
            //for (var i = 1; i < 4; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    //var input = Console.ReadLine();
            //    var num = Convert.ToInt32(Console.ReadLine());
            //    var randomnum = random.Next(1, 10);
            //    if (num == randomnum)
            //        Console.WriteLine("You won");
            //    else
            //        Console.WriteLine("Hard luck");
            //}

            //Exercise 5
            Console.WriteLine("Enter a series of number with , separator");
            var input = Console.ReadLine();

            var input1 = input.Split(',');
            var max = Convert.ToInt32(input1[0]);

            foreach (var i in input1)
            {
                var num = Convert.ToInt32(i);
                if (num > max)
                    max = num;


            }
            Console.WriteLine("The largest number of the input numbers provided is " + max);
        }
    }
}
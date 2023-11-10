using System;
using System.Threading;

namespace CreatingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            var mythread = new Thread(Sum);
            //we pass the value in start method of the thread
            mythread.Start(new int[] { 1, 2, 3, 4, 5 });

            //for thread to accept multiple parameters create a class that accommodates 2 types
            var parameters = new MultiplierParameters() { Text = "Bingo", Multiplier = 5 };
            var mythread2 = new Thread(RepeatSeveralTimes);
            //we pass the parameters in start method of the thread
            mythread2.Start(parameters);
        }

        //our method accepts parameter of type object
        static void Sum(object numbers)
        {
            //as we want to have multiple values of type int, let's encapsulate inside an array
            var intArray = numbers as int[];
            var sum = 0;
            foreach (var number in intArray)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }

        static void RepeatSeveralTimes(object textMultiplier)
        {
            if (textMultiplier is MultiplierParameters)
            {
                var castedparameters = (MultiplierParameters)textMultiplier;
                var output = "";

                for (int i = 0; i < castedparameters.Multiplier; i++)
                {
                    output += castedparameters.Text + " ";

                }
                Console.WriteLine(output);
            }
        }
    }
}
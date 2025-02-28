using System;
namespace Float_Beginner
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declare a float variable and assign a value to it
            float myFloat = 3.14f;
            double myFloat2 = 3.14;

            Console.WriteLine($"The value of myFloat is {myFloat}");

            var delay = TimeSpan.FromSeconds(1);
            Console.WriteLine($"Value of dealy is : {delay} and type is {delay.GetType()}");

            var backoffmultiplier = delay * (myFloat * (2-1));
            var backoffmultiplier2 = delay * myFloat2;
            Console.WriteLine($"Value of backoffmultiplier is : {backoffmultiplier} and type is {backoffmultiplier.GetType()}");
            Console.WriteLine($"Value of backoffmultiplier2 is : {backoffmultiplier2} and type is {backoffmultiplier2.GetType()}");
            Task.Delay(backoffmultiplier);
            Console.WriteLine("Task Delayed by backoffmultiplier");
        }
    }

}
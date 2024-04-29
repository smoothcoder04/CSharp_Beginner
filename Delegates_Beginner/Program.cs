using System;

namespace Delegates
{
    delegate void Printmymessage();
    //pass delegate as method parameter
    delegate void MessageParametersample(string message);

    //Revision: 29th April 2024
    public delegate void CalculateAdditionDelegate(int a, int b);
    public delegate void CalculateSubstractionDelegate(int a, int b);
    class Program
    {
        public static void Main(string[] args)
        {
            string mood = "OK";
            //Printmymessage Mymood;

            if (mood == "Good")
            {
                Printmymessage Mymood = new Printmymessage(Mymessagemotivation);
                Mymood();
            }
            else
            {
                Program myprogram = new Program();
                Printmymessage Mymood = myprogram.Mymessageemotion;
                Mymood.Invoke();
            }

            MessageParametersample Mymessage = MessageParam;
            MethodPraramInvoker(Mymessage, "Stay Focussed");

            //revision 29th apr 2024
            //create instanc of PerformCalculation
            PerformCalculation mycalculator = new PerformCalculation(10, 20);
            //create delegate instance and assign method
            CalculateAdditionDelegate additionDelegate = mycalculator.Add;
            CalculateSubstractionDelegate substractionDelegate = mycalculator.Substract;
            additionDelegate(10, 20);
            substractionDelegate(100, 50);
        }
        static void Mymessagemotivation()
        {
            Console.WriteLine("You are doing great. keep it up");
        }

        public void Mymessageemotion()
        {
            Console.WriteLine("So proud of you...");
        }

        static void MessageParam(string message)
        {
            Console.WriteLine($"******{message}******");
        }

        static void MethodPraramInvoker(MessageParametersample samplemessage, string message)
        {
            samplemessage?.Invoke(message);
        }



    }
}
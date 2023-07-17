using System;

namespace Delegates
{
    delegate void Printmymessage();
    //pass delegate as method parameter
    delegate void MessageParametersample(string message);
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
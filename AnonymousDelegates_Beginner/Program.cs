using System;

namespace AnonymousDelegates
{
    delegate void MySample();
    delegate void MySampleMessage(string message);
    delegate void MySampleMessage2(string message);
    
    class Program
    {
        public static void Main(string[] args)
        {
            MySample newSample = delegate ()
            {
                Console.WriteLine("You are using Anonymous delegate feature in C#.. Cool!!!!....");
            };
            newSample();

            PrintMessage("Laptop", delegate (string message)
            {
                Console.WriteLine(message);
            });

            //pass anonymous method as parameter inside AnonymousMethodSample
            AnonymousMethod.AnonymousMethodSample(delegate(string colour)
            {
                Console.WriteLine($"The colour of of my pet is {colour}" );
            }, "Pink");

        }
        static void PrintMessage(string messagedevice, MySampleMessage2 message)
        {
            Console.WriteLine($"Learning is fun!!!!!!!!!!!!, {message}");
            message(messagedevice);
        }
        

    }
}

using MyDemo.Math;
using System;

namespace MyDemo
{

    class MainClass
    {
        //value & reference type
        public static void Increment(int i)
        {
             i += 1;
        }

        public static void MakeYoung(Person person)
        {
            person.Age -= 10;
        }

        static void Main(string[] args)
        {
  
            //var jhon = new Person();
            //jhon.FristName = "Jhon";
            //jhon.LastName = "Smith";
            //jhon.Introduce();

            ////Calculator calculator = new Calculator();
            //var result = Calculator.Add(2, 6);
            //System.Console.WriteLine("the result is " +result);
           

            //Array

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //String

            string myFistName = "Mithu";
            string myLastName = "MM";

            var fullName = myFistName + " " + myLastName;
            Console.WriteLine(fullName);
            var name = string.Format("My full name is {0} {1}", myFistName, myLastName);
            Console.WriteLine(name);
            var namejoint = new string[] { "Hello", "Mithu", "!" };
            var sampleName = string.Join(" ", namejoint);
            Console.WriteLine(sampleName);
            Console.WriteLine(namejoint);

            var text = string.Format (@"hi {0}
                                        do you recognise C:\\mawhinneym\\drivers ?", namejoint[1]);
            Console.WriteLine(text);


            var age = 2;
            Increment(age);
            Console.WriteLine(age);

            var person = new Person();
            person.Age = 30;

            MakeYoung(person);
            Console.WriteLine(person.Age);


        }
    }


}

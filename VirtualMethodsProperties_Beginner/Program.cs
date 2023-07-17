using System;

namespace VirtualMethProp
{
    class Program
    {
        public static void Main()
        {
            Cow MyCow = new Cow();
            Animal MyAnimal = new Animal();
            Dog MyDog = new Dog();

            Console.WriteLine($"Cow say : {MyCow.Voice}");
            MyCow.Voicy();
            Console.WriteLine($"Dog say : {MyDog.Voice}");
            MyDog.Voicy();
            Console.WriteLine($"Animal say : {MyAnimal.Voice}");
            MyAnimal.Voicy();
        }
    }
}
using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticMembers.Person.population = 1000000000000;
            var initialPopulation = StaticMembers.Person.population;
            Console.WriteLine($"The initial population is {initialPopulation}");
            Console.WriteLine($"The initial population other is {StaticMembers.Person.population}");

            var person1 = new Person();
            var person2 = new Person();
            var person3 = new Person();
            var person4 = new Person();
            var person5 = new Person();

            var personBorn = Person.Population - initialPopulation;
            Console.WriteLine($"{personBorn} persons were born.");
            Console.WriteLine($"Current population is {Person.Population}.");

            int mynum = 10;
            Person.IncreaseByOne(ref mynum);
            Console.WriteLine($"The number after it is increased is = {mynum}");
        }
    }
}
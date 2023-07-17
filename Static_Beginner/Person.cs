using System;


namespace StaticMembers
{
    internal class Person
    {

        public static long population;
        public static long Population
        {
            get { return population; }
            set { population = value; }
        }
        public int Testvar { get; set; }
        public Person()
        {

            Population += 1;
        }

        //static method
        public static void IncreaseByOne(ref int num)
        {
            num++;
        }

    }
}
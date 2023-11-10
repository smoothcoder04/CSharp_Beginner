using System;
// List<T> reside in this namespace
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine($" Number of elements in list is - {list.Count}");

            //Add another collection
            list.AddRange(new[] { 98, 99, 100 });

            list.Add(1000);

            Console.WriteLine($" Number of elements in list after Add range is - {list.Count}");
            Console.WriteLine($" 6th  elements in list  - {list[5]}");


            list.RemoveAll(x => x >= 300);
            Console.WriteLine($"The new list after removeall is - {list.Count}");

            bool numberExistsOrNot = list.Remove(10000);
            Console.WriteLine($"Does The number exist? = {numberExistsOrNot}");

            list.RemoveAt(0);
            Console.WriteLine($" Number of elements in the list - {list.Count}");

            List<int> myList = new List<int> { 1, 10, 20, 30, 0, };
            myList.Sort();
            var indexof30 = myList.BinarySearch(30);

            Console.WriteLine($"the index of 30 is {indexof30}");
            Console.WriteLine($"the capacity of list is {myList.Capacity}");
            myList.TrimExcess();
            Console.WriteLine($"the capacity of list is {myList.Capacity}");
            //sort 
            Algo<int> myAlgo = new Algo<int>(myList);
            myAlgo.PrintList(myList);


            List<string> myStringList = new List<string> { "Hello", "Welcome", "Thankyou", "Bye", "OK", "Off", };
            Algo<string> myAlgoString = new Algo<string>(myStringList);
            myAlgoString.PrintList(myStringList);

        }
    }
}
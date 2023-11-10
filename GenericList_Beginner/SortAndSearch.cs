using System;
using System.Collections.Generic;

namespace GenericList
{
    public class Algo<T>
    {
        public List<T> list { get; set; }
        public Algo(List<T> list)
        {
            this.list = list;
        }

        public void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();

        }
    }
}
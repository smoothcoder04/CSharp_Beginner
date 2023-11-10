// This dictionary example counts how many times a character repeats itself

using System;
//Dictionary reside in this namespace
using System.Collections.Generic;


namespace DictionaryFirst
{
    class Program
    {
        static void Main(string[] args)

        {
            var mytext = Console.ReadLine();
            var myDictionary = new Dictionary<char, int>();

            foreach (var item in mytext)
            {
                //if it is a space, disregard
                if (char.IsWhiteSpace(item))
                {
                    continue;
                }
                // the character exists in dictionary already
                if (myDictionary.ContainsKey(item))
                {
                    myDictionary[item]++;
                }

                //This charater doesn't exist in the dictionary yet, so it is the first time it is seen
                else
                {
                    myDictionary.Add(item, 1);
                }
            }
            //Keys roperty returns all the keys
            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine($"{item} -->{myDictionary[item]}");
            }

            //New dictionary

            var newDictionary = new Dictionary<string, double>();
            newDictionary.Add("Mithu", 32);
            newDictionary.Add("Phoebe", 2.3);
            newDictionary.Add("Louie", 4.4);
            newDictionary.Add("Ross", 43);

            foreach (var item in newDictionary.Keys)
            {
                Console.WriteLine($"{item} -->{newDictionary[item]}");
            }

        }
    }
}
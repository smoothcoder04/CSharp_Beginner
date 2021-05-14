using System;
using System.Collections.Generic;

namespace Application_Debug
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of 5 numbers");
            var input = Console.ReadLine();
            if (!input.Contains(" ") || input.Length >= 5)
            {
                var arrlist = smallestFunc(input);
                Console.WriteLine("the thre smalles numbers of the provided one: {0}, {1} & {2}",
                    arrlist[0], arrlist[1], arrlist[2]);
            }


            else
                Console.WriteLine("Invalid entry, try again");


        }

        public static List<int> smallestFunc(string str)
        {
            
            
            var arr = new List<int> { };
            
            {
                
                var listnew = str.Split(',');
                foreach (var i in listnew)
                {
                    var listnum = Convert.ToInt32(i);
                    arr.Add(listnum);
                }
                arr.Sort();
                return arr;
                
                
            }
            
        }
    }
}

    
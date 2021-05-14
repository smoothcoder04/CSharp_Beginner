using System;
using System.Collections.Generic;

namespace ArrayList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var numbers = new[] { 3, 4, 5, 100, 7, 8, 9, 14 };
            ////length
            //Console.WriteLine("Length :" + numbers.Length);

            ////IndexOf
            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("Index of 9 is" +index);

            ////clear()
            //Array.Clear(numbers, 1, 2);
            //Console.WriteLine("Effect of clear()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            ////Copy()
            //int[] another = new int[3];
            //Array.Copy(numbers,another,3);
            //Console.WriteLine("Effect of copy()");
            //foreach (var n in another)
            //    Console.WriteLine(n);

            ////Sort
            //Array.Sort(numbers);
            //Console.WriteLine("Effect of sort()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            ////Reverse
            //Array.Reverse(numbers);
            //Console.WriteLine("Effect of reverse()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            //LISTS

            //var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 7,8,9});
            //foreach(var num in numbers)
            //    Console.WriteLine(num);

            //Console.WriteLine( "Index of 9 : " +numbers.IndexOf(9));
            //Console.WriteLine("last Index of 1 : " + numbers.LastIndexOf(1));
            //Console.WriteLine("Count : " +numbers.Count);

            //for(var i=0; i < numbers.Count; i++)
            //{
            //    //if(numbers[i]==1)
            //    numbers.Remove(1);
            //}
            // foreach (var n in numbers)
            //    Console.WriteLine(n);

            //numbers.Clear();
            //Console.WriteLine("Count : " + numbers.Count);

            //Exercise 1
            //var names = "";
            //var users = new List<string>();
            //while (true)
            //{

            //    Console.WriteLine("Enter a name :");
            //    names = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(names))
            //        break;
            //    else
            //        users.Add(names);
            //}

            //if (users.Count <=2)
            //{

            //        Console.WriteLine("{0} & {1} liked your picture", users[0], users[1]);
            //}
            //if (users.Count >= 3)
            //{

            //    Console.WriteLine("{0} & {1} & others like your picture", users[0], users[1]);
            //}
            //if (users.Count == 1)
            //        Console.WriteLine("{0} like your pickture", users[0]);

            //Exercise 2
            //Console.WriteLine("Enter your name :");
            //string name = Console.ReadLine();   //accept user input in the variable name
            //var namearr = new char[name.Length];  //create an array of size name that has been provided by the user. character array not string array so that it is easier to go through them

            //for(var i = name.Length; i > 0; i--)
            //{
            //    namearr[name.Length - i] = name[i-1];
            //}
            //var reversed = new string(namearr);

            //Console.WriteLine("reverse name : {0}", reversed);


            //}

            //Exercise 3
            //var arr = new List<int>() { };
            //for (var i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Enter a number:");
            //    var num = Convert.ToInt32(Console.ReadLine());

            //    if (arr.Contains(num))
            //    {
            //        Console.WriteLine("Error, enter unique number");
            //        continue;
            //    }
            //    else
            //    {
            //        arr.Add(num);
            //        arr.Sort();
            //        foreach (var j in arr)
            //            Console.WriteLine(j);
            //    }

            //}


            //Exercise 4
            //var arr = new List<int>();
            //var uniquearr = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Enter a number or type Quit to exit");
            //    var input = Console.ReadLine();
            //    if (input == "quit")
            //        break;
            //    //var num = Convert.ToInt32(input);
            //    arr.Add(Convert.ToInt32(input));
            //}

            //foreach(var n in arr)
            //{
            //    if (!uniquearr.Contains(n))
            //        uniquearr.Add(n);
            //}
            //Console.WriteLine("Unique entries in the array :" );
            //foreach(var z in uniquearr)
            //    Console.WriteLine(z);

            //Exercise 5
            //Console.WriteLine("Enter a list of 5 numbers");
            //var input = Console.ReadLine();
            //var arr = new List<int> { };
            //if (!input.Contains(" ") || input.Length >= 5)
            //{
            //    var listnew = input.Split(',');
            //    foreach (var i in listnew)
            //    {
            //        var listnum = Convert.ToInt32(i);
            //        arr.Add(listnum);
            //    }
            //    arr.Sort();
            //    Console.WriteLine("The 3 smallest numbers : {0}, {1} & {2}", arr[0], arr[1], arr[2]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid entry, try again");
            //}
            //}
            //var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //var index = numbers.IndexOf(1);

            //Console.WriteLine(index);

            var datetime = new DateTime(2020, 1,1);
            var today =  DateTime.Now;
            var yesterday = DateTime.Today;
            Console.WriteLine("Today: " + today);
            Console.WriteLine("Yesterday: "  + (today.AddDays(-1)));

            var timeSpan = new TimeSpan(1,2,3);
            Console.WriteLine("TiomeSpan value : " +timeSpan);
            Console.WriteLine("TimeSpan minutes: " +timeSpan.Minutes);
            Console.WriteLine("Add 2 minutes to the timespan: " + timeSpan.Add(TimeSpan.FromMinutes(2)));
        }
             

           
        
        }
    }
//    }


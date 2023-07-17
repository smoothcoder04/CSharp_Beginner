using System;

namespace GenericInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Holder<int> myholder = new Holder<int>(2);
            myholder.Items[0] = 100;
            myholder.Items[1] = 200;

            BetterHolder<string> myholderstring = new BetterHolder<string>(2);
            myholderstring.Items[0] = "Train";
            myholderstring.Items[1] = "Bus";


            Console.WriteLine(myholder.ToString());
            Console.WriteLine(myholderstring.ToString());

        }
    }
}
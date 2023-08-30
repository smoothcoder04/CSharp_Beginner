using System;

namespace InterfaceConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Brave val = new Brave<string>();
            val.Value = "Hello";
            val.Convert();

        }
    }
}

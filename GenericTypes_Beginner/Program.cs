//Toolbox example

using System;

namespace GenericTypeSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            //without Generic type
            //Toolbox Toolholder = new Toolbox(5);
            //Toolholder.Tools[0] = "Hammer";
            //Toolholder.Tools[1] = "ScrewDriver";
            //Toolholder.Tools[2] = "NailBox";
            //Toolholder.Tools[3] = "Pencil";

            Toolbox<int> ToolholderNumber = new Toolbox<int>(5);
            ToolholderNumber.Tools[0] = 1;
            ToolholderNumber.Tools[1] = 2;
            ToolholderNumber.Tools[2] = 3;
            ToolholderNumber.Tools[3] = 4;

            Console.WriteLine(ToolholderNumber.ToString());

            Toolbox<string> ToolholderString = new Toolbox<string>(5);
            ToolholderString.Tools[0] = "Pen";
            ToolholderString.Tools[1] = "PencilBox";

            Console.WriteLine(ToolholderString.ToString());
            string mydefaultstring = GetDefault<string>();
            int mydefaultnum = GetDefault<int>();

            if (mydefaultstring == null)
            {
                Console.WriteLine("Default string: null");
            }
            Console.WriteLine($"Default integer: {mydefaultnum}");


        }
        //Generic Method
        private static T GetDefault<T>()
        {
            return default(T);
        }
    }
}
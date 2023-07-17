using System;

namespace SystemObjectClassSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Toolbox Toolholder = new Toolbox(5);

            Toolholder.Tools[0] = "Hammer";
            Toolholder.Tools[1] = "Screwdriver";
            Toolholder.Tools[2] = "SwissKnife";
            Toolholder.Tools[3] = "Pencil";
            Toolholder.Tools[4] = "NailBox";

            Console.WriteLine(Toolholder.ToString());

        }
    }
}

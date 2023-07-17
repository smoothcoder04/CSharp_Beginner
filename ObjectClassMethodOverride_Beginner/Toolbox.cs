using System;

namespace SystemObjectClassSample
{
    public class Toolbox
    {
        //set a variable where you can pick whatwver tool you want to use
        public string[] Tools { get; private set; }

        //initialize array to hold the tools inside the box
        public Toolbox(int toolBoxSize)
        {
            Tools = new string[toolBoxSize];
        }

        public override string ToString()
        {
            string result = "Tools inside : ";
            foreach (var tool in Tools)
            {
                result = result + tool + " ";
            }
            return result;
        }

    }
}
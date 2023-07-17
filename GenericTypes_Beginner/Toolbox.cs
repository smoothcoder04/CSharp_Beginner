using System;
namespace GenericTypeSample
{
    //<T> -- means the class will accept a Type parameter
    public class Toolbox<T>
    {
        //inject the type parameter, replace string type with genertic type
        public T[] Tools { get; set; }

        public Toolbox(int toolboxsize)
        {
            //replace string with generic type
            Tools = new T[toolboxsize];
        }

        public override string ToString()
        {
            string result = "Items inside : ";
            foreach (var tool in Tools)
            {
                result = result + tool + " ";
            }
            return result;
        }
    }
}
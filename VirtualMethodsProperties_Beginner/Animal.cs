using System;

namespace VirtualMethProp
{
    public class Animal
    {
        public string Voice = "Zoo";
        public virtual void Voicy()
        {
            Console.WriteLine("Otter");
        }

    }
}
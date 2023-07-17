using System;

namespace GenericInheritance
{
    public class Holder<T>
    {
        public T[] Items { get; set; }

        public Holder(int holdersize)
        {
            Items = new T[holdersize];
        }

        public override string ToString()
        {
            string result = "Items inside: ";

            foreach (var item in Items)
            {
                result = result + item + " ";
            }

            return result;
        }
    }
}
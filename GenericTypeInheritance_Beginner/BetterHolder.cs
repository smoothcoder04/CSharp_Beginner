using System;

namespace GenericInheritance
{
    public class BetterHolder<T> : Holder<T>
    {
        public T this[int index]
        {
            get
            {
                return this.Items[index];
            }
            set
            {
                this.Items[index] = value;
            }
        }
        public BetterHolder(int holdersize)
        : base(holdersize)
        {

        }
    }
}
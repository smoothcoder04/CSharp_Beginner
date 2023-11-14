using System;

namespace CustomAttribute
{
    public class MinLengthAttribute : Attribute
    {
        public int MinLength { get; set; }
        public MinLengthAttribute() { }
        public MinLengthAttribute(int minLength)
        {
            this.MinLength = minLength;
        }
    }
}
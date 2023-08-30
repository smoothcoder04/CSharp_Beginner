using System;

namespace InterfaceConstraints
{

    public class Brave : IConvertible<string>
    {
        public string Value { get; set; }
        public T Convert()
        {
            return Value as T;
        }
    }
}
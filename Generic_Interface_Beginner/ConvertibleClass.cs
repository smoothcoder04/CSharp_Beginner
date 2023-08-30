using System;

namespace GenericInterface
{
    public class ConvertibleClass<T> : IConvertible<T> where T : class
    {

        public object SomeValue { get; set; }
        public T Convert()
        {
            return SomeValue as T;
        }
    }
}
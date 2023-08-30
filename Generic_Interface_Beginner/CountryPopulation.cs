//Inherits generic interface

using System;

namespace GenericInterface
{
    public class CountryPopulation : IConvertible<int>
    {
        public string CountryName { get; set; }
        public long Population { get; set; }

        public int Convert()
        {
            return (int)Population;
        }
    }
}
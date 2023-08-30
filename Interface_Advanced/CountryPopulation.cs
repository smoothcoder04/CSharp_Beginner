using System;

namespace Interface_Advanced
{
    public class CountryPopulation : INumeric, IConvertible
    {
        public string Country { get; set; }
        public int NumberOfPeople { get; set; }

        public int ToInt32()
        {
            return NumberOfPeople;
        }

        public long ToInt64()
        {
            return Convert.ToInt64(NumberOfPeople);
        }

        int IConvertible.ToInt32()
        {
            return NumberOfPeople / 2;
        }

    }
}
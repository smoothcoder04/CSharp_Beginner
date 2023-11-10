using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqQueries
{
    class Program
    {
        public static void Main(string[] args)
        {
            var countries = new List<string>()
            {
                "Germany", "Thailand", "France", "Spain",
                "Italy", "United States", "Romania", "Russia",
                "Greece", "Argentina", "Canada", "Mexico",
                "Ireland", "Albania", "Slovenia", "Turkey"
            };

            //create query
            var countriesstartwithT = (from country in countries
                                       where country.StartsWith("T")
                                       select country).ToList();

            countries.Remove("Thailand");

            Console.WriteLine($"Number of countries that starts with T = {countriesstartwithT.Count()}");


        }
    }
}
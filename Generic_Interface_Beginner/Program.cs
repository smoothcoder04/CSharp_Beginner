using System;

namespace GenericInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var convertibleClass = new ConvertibleClass<string>();
            convertibleClass.SomeValue = "Hello World";
            Console.WriteLine(convertibleClass.Convert());

            var countryPopulation = new CountryPopulation
            { CountryName = "United States", Population = 30000000 };
            Console.WriteLine(countryPopulation.Convert());
        }
    }
}
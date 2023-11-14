using System;
using System.Reflection;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var profile = new UserProfile
            {
                Username = "LongUserName",
                Password = "longpasswordforuse123456789"
            };
            var stringLengthsAreValid = ValidStringLength(profile);

            Console.WriteLine($"All string properties meet minimum length requirements: {stringLengthsAreValid}");
        }
        //this method will return true if the properties of obj marked with MinLengthAttribute have the length >= MinLength
        static bool ValidStringLength(object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                object[] attributes = property.GetCustomAttributes(false);

                foreach (var attribute in attributes)
                {
                    if (attribute is MinLengthAttribute)
                    {
                        var minLength = ((MinLengthAttribute)attribute).MinLength;

                        if (property.PropertyType == typeof(string))
                        {
                            var propertyValue = (string)property.GetValue(obj);
                            return propertyValue.Length >= minLength;
                        }
                    }
                }
            }
            return true;
        }
    }
}
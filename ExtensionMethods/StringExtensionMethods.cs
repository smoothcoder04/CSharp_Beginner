using System;

namespace Extensions
{
    //static class
    public static class StringExtensionMethods
    {
        public static string Reverse(this string stringObject)
        {
            char[] charArray = stringObject.ToCharArray();
            char[] reversedArray = new char[charArray.Length];

            for (int i = charArray.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = charArray[i];
            }
            return new string(reversedArray);
        }

    }
}
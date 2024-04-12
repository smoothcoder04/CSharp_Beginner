using System;

namespace CharSplit
{
    public static class ExtensionMethodCharSplit
    {
         public static int CharSplitCount(this string input)
         {
            return input.Split(new char[] {' ', '.', '?'},
                                StringSplitOptions.RemoveEmptyEntries).Length;
         }
    }
}
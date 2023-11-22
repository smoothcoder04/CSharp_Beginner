using System;
using System.Text.RegularExpressions;

namespace RegExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Heelllooo World!! I am using this string to store some valuable information.";
            var regexRule = new Regex((@"(\w*)or(\w*)"));
            var matches = regexRule.Matches(text);

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
            else
            {
                Console.WriteLine("No matches found!!");
            }
        }
    }
}
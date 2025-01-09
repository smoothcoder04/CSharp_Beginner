using System.Collections;
using System.Collections.Specialized;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static StringCollection GenerateNames()
{
    StringCollection names = new StringCollection();
    names.Add("Beetles");
    names.Add("Oasis");
    return names;
}

static void PrintNames(StringCollection names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

PrintNames(GenerateNames());
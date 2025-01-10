using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static List<string> GenerateNames()
{
    List<string> names = new List<string>();
    names.Add("Alpha");
    names.Add("Beta");
    names.Add("Gamma");
    return names;
}

static void PrintNames(List<string> names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

PrintNames(GenerateNames());
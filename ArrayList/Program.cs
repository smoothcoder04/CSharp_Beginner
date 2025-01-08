using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static ArrayList GenerateNames()
{
    ArrayList names = new ArrayList();
    names.Add("Lambda");
    names.Add("Gamma");
    return names;
}

static void PrintNames(ArrayList names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}


PrintNames(GenerateNames());
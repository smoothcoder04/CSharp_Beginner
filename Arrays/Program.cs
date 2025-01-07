// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static string[] GenerateNames()
{
    string[] names = new string[4];
    names[0] = "Louie";
    names[1] = "Phoebe";
    names[2] = "MiMaw";
    names[3] = "RoMaw";
    return names;
}
static void PrintNames(string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

var names = GenerateNames();
PrintNames(names);

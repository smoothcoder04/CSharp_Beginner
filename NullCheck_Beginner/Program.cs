// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int? age = null;
int? age = 5;
Console.WriteLine($"value of age - {age.GetType()} ");

if (age != null)
{
    Console.WriteLine($"The value of age isn't null - {age}");
}

string houseNumber = null;

string address = houseNumber ?? "3 Wagtail Close";
Console.WriteLine($"the address is ==== {address}");
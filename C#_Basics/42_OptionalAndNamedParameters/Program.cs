using System;

class Program
{
    static void DisplayInfo(string name, int age = 18, string country = "Pakistan")
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Country: {country}");

    }
    static void Main(string[] args)
    {
        // Using all parameters
        DisplayInfo("Aslam", 20, "UK");

        Console.WriteLine();

        // Use Optional Parameter
        DisplayInfo("Ahmad");

        // Using named parameters (order does'nt matter)
        DisplayInfo(
            "Sara",
            34,
            "India"
            );
    }
}
using System;

class Program
{
    static void Main()
    {
        // Creating strings
        string name = "Ali Ahsan";
        string greeting = "Hello, " + name + "!";

        Console.WriteLine(greeting); // Output: Hello, Ali Ahsan!

        // String properties
        Console.WriteLine("Length of name: " + name.Length); // 9

        // Changing case
        Console.WriteLine(name.ToUpper()); // ALI AHSAN
        Console.WriteLine(name.ToLower()); // ali ahsan

        // Substring
        string sub = name.Substring(0, 3);
        Console.WriteLine("Substring: " + sub); // Ali

        // Contains
        Console.WriteLine(name.Contains("Ahsan")); // True

        // IndexOf
        Console.WriteLine(name.IndexOf("A")); // 0

        // Replace
        string newName = name.Replace("Ali", "Ahmed");
        Console.WriteLine(newName); // Ahmed Ahsan

        // Trim
        string text = "   C# Programming   ";
        Console.WriteLine(text.Trim()); // C# Programming

        // Split
        string[] words = text.Trim().Split(' ');
        Console.WriteLine("Words count: " + words.Length); // 2

        // StartsWith / EndsWith
        Console.WriteLine(name.StartsWith("Ali")); // True
        Console.WriteLine(name.EndsWith("Ahsan")); // True
    }
}

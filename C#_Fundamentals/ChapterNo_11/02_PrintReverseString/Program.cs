using System;

class Reverse
{
    public static void PrintReverseArray(string s)
    {
        char[] charArray = s.ToCharArray();

        Array.Reverse(charArray);

        string reverse = new string(charArray);

        Console.WriteLine($"Reversed string is: {reverse}");
    }

    static void Main(string[] args)
    {
        string name = "Ali Ahsan";
        PrintReverseArray(name);
    }
}
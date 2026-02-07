using System;

class Program
{
    // Generic method with constraint
    // T must implement IComparable
    public static T GetMax<T>(T a, T b) where T : IComparable<T>
    {
        // Compare two values
        if (a.CompareTo(b) > 0)
            return a;
        else
            return b;
    }

    static void Main()
    {
        int maxInt = GetMax(10, 20);
        Console.WriteLine("Max int: " + maxInt);

        string maxString = GetMax("Apple", "Banana");
        Console.WriteLine("Max string: " + maxString);
    }
}

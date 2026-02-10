using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class Program
{
    static void Main()
    {
        // Create a normal list
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango"
        };

        // Create a ReadOnlyCollection from the list
        ReadOnlyCollection<string> readOnlyFruits =
            new ReadOnlyCollection<string>(fruits);

        // Display items from read-only collection
        Console.WriteLine("Fruits in ReadOnlyCollection:");
        foreach (var fruit in readOnlyFruits)
        {
            Console.WriteLine(fruit);
        }

        // Try to modify the read-only collection
        // readOnlyFruits.Add("Orange"); // ❌ Compile-time error
        // readOnlyFruits.Remove("Apple"); // ❌ Not allowed

        // But we can still modify the original list
        fruits.Add("Orange");

        Console.WriteLine("\nAfter modifying original list:");
        foreach (var fruit in readOnlyFruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Nested list (list of lists)
        List<List<int>> numbers = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 },
            new List<int> { 5, 6 }
        };

        // Flatten the nested lists into a single list
        var flattened = numbers
            .SelectMany(innerList => innerList);

        // Print flattened result
        Console.WriteLine("Flattened numbers:");
        foreach (var num in flattened)
        {
            Console.WriteLine(num);
        }
    }
}

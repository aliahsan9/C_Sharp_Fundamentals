using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        List<int> numbers = new List<int> { 10, 30, 77, 88, 89, 100 };

        // Use of Any
        bool AnyGreaterThan90 = numbers.Any(n => n > 90);

        Console.WriteLine(AnyGreaterThan90);

        // Use of All
        bool AllGreaterThan90 = numbers.All(n => n > 90);
        Console.WriteLine(AllGreaterThan90);

        // Use of Contains
        bool Contains = numbers.Contains(10);

        Console.WriteLine(Contains);
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            1, 2, 3, 2, 4, 1, 5, 3
        };

        // HashSet automatically removes duplicates
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        Console.WriteLine("After removing duplicates:");
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

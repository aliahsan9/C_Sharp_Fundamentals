using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // ==============================
        // 🔹 DEFERRED EXECUTION
        // ==============================

        // Query is created here
        // BUT NOT executed yet ❗
        var evenNumbersDeferred = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Deferred Execution:");

        // Modify the original collection AFTER query creation
        numbers.Add(6);

        // Query runs NOW when we iterate it
        foreach (var num in evenNumbersDeferred)
        {
            Console.WriteLine(num);
        }

        // Output will be:
        // 2
        // 4
        // 6  <-- included because execution happened later

        Console.WriteLine("-------------------");

        // ==============================
        // 🔹 IMMEDIATE EXECUTION
        // ==============================

        List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };

        // ToList() forces the query to run immediately
        var evenNumbersImmediate = numbers2
                                    .Where(n => n % 2 == 0)
                                    .ToList(); // 🔥 Executed here

        Console.WriteLine("Immediate Execution:");

        // Modify original collection AFTER execution
        numbers2.Add(6);

        foreach (var num in evenNumbersImmediate)
        {
            Console.WriteLine(num);
        }

        // Output will be:
        // 2
        // 4
        // ❌ 6 will NOT be included
    }
}
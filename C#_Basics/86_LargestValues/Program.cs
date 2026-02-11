using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        List<int> numbers = new List<int> { 10, 30, 70, 50, 100, 80};

        // Sort Numbers in ascending
        // Now take top 3
        var top3 = numbers
            .OrderByDescending(n => n)
            .Take(3);

         // Now print results

        foreach(var num in top3)
        {
            Console.WriteLine($"{num}");
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;

public static class CustomLinqExtensions
{
    public static IEnumerable<int> FilterEvenNumbers(this IEnumerable<int> source)
    {
        foreach(var item in source)

            if(item % 2 == 0)
        {
            yield return item;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.FilterEvenNumbers();

        Console.WriteLine("Even Numbers:");
        foreach(var num in result)
        {
            Console.WriteLine(num);
        }
    }
}
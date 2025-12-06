using System;
using System.Collections.Generic;
using System.Linq;

class SunAndAverage
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input;

        Console.WriteLine("Enter any positive integers (press enter on ampty input to stop!)");

        while(true)
        {
            input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            break;

            if(int.TryParse(input, out int number) && number > 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Enter any valid input!");
            }
        }
        if(numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine($"\nSum = {sum}");
            Console.WriteLine($"Average = {average:F2}");
        }
        else
        {
            Console.WriteLine("Enter any valid input!");
        }
    }
}
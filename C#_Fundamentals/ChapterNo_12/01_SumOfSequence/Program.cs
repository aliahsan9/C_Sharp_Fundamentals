using System;
using System.Collections.Generic;

class SumOfSequence
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter any positive integers (press enter on any empty line to finish:)");

        while(true)
        {
            string input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input)) // Stop on white space
            break;

            if (int.TryParse(input, out int number) && number > 0)
            {
               numbers.Add(number); 
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer!");
            }
        }
        if(numbers.Count > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered!");
        }
    }
}
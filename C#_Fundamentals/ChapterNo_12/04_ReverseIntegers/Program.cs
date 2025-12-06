using System;
using System.Collections.Generic;
using System.Linq;

class ReversedIntegers
{
    public static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();
        string input;

        Console.WriteLine("Enter any positive integers to reverse them!");

        while(true)
        {
            input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            break;

            if(int.TryParse(input, out int number) && number > 0)
            {
                numbers.Push(number);
            }
            else
            {
                Console.WriteLine("Input Invalid!");
            }
        }
        if(numbers.Count > 0)
        {
            Console.WriteLine("\nReversed Integers are:");

           while (numbers.Count > 0)
           {
            
            Console.Write(numbers.Pop() + " ");
        }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
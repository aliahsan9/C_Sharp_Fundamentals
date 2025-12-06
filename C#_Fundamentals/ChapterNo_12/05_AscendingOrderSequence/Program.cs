using System;
using System.Collections.Generic;
using System.Linq;

class SortAscending
{
    public static void Main(string[]args)
    {
        List<int> numbers = new List<int>();
        string input;
        Console.WriteLine("Enter any positive Integers (press enter on empty space to stop!)");

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
                Console.WriteLine("Invalid Input!");
            }
        }
          //Bubble Sort Implementation
            for(int i = 0; i < numbers.Count - 1; i++)
            {
                for(int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        //Swap Integers
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array is:");
            Console.WriteLine(string.Join(", ", numbers));
        }
}
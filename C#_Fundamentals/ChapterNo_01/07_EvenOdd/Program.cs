using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any integer:");
        string input = Console.ReadLine();

        if(int.TryParse(input , out int number))
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is an Even number.");
            }
            else 
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
            else
            {
                Console.WriteLine("InValid input! please enter a valid input again!");
            }
        }
    }
    
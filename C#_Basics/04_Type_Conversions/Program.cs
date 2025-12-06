using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a First Number:");
        string firstNumber = Console.ReadLine();
        int num1 = Convert.ToInt32(firstNumber);

        Console.WriteLine("Enter a Second Number:");
        string secondNumber = Console.ReadLine();
        int num2 = Convert.ToInt32(secondNumber);


        int sum = num1 + num2;

        Console.WriteLine("Sum of num1 & num2 is: " + sum);

    }
}
using System;

class Program
{
    static string GetLastDigitName(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        string[] digitNames =
                {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

        return digitNames[lastDigit];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any velaue:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"English name of last digit is: {GetLastDigitName(num)}");
    }
}
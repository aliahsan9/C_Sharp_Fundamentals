using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int reverse = 0;

        // Reverse the number
        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }

        Console.WriteLine($"Reversed number: {reverse}");

        // Palindrome check
        if (originalNumber == reverse)
            Console.WriteLine("The number is a Palindrome");
        else
            Console.WriteLine("The number is Not a Palindrome");
    }
}

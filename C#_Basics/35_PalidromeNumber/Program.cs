using System;

class Program
{
    static void Main()
    {
        // Ask user to enter a number
        Console.Write("Enter a number: ");

        // Read the number from input and convert it to int
        int number = int.Parse(Console.ReadLine());

        // Store the original number for later comparison
        int originalNumber = number;

        // This variable will store the reversed number
        int reverse = 0;

        // Loop runs until number becomes 0
        while (number > 0)
        {
            // Get the last digit of the number
            // Example: 123 % 10 = 3
            int digit = number % 10;

            // Build the reversed number
            // Example: reverse = 0 * 10 + 3 → 3
            reverse = reverse * 10 + digit;

            // Remove the last digit from the number
            // Example: 123 / 10 = 12
            number = number / 10;
        }

        // Print the reversed number
        Console.WriteLine($"Reversed number: {reverse}");

        // Check if original number and reversed number are same
        if (originalNumber == reverse)
            Console.WriteLine("The number is a Palindrome");
        else
            Console.WriteLine("The number is Not a Palindrome");
    }
}

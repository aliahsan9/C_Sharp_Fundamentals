using System;

class LargestNumber
{
    static void Main(string[] args)
    {
        int a = 5, b = 10, c = 15;

        // Using Conditional Operators
         int largest = (a > b && a > c) ? a 
            : (b > c) ? b 
            : c;
        Console.WriteLine($"Largest number is: {largest}");
    }
}
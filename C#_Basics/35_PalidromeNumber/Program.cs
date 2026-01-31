using System;

class PalidromeNumbers
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter any number:");
        int num = int.Parse(Console.ReadLine());

        int originalNumber = num;
        int reverse = 0;

        while(num > 0)
        {
            int digit = num % 10;
            reverse = reverse % 10 + digit;
            num = num / 10;
        }
        Console.WriteLine($"Reverse number:{reverse}");

            if(originalNumber == reverse)
        {
            Console.WriteLine("Number is a Palidrome!");
        }
        else
        {
            Console.WriteLine("Number is not a Palidrome!");
        }
    }
}
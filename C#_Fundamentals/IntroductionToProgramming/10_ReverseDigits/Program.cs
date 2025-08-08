using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a 4_digit number(abcd):");
        int number = int.Parse(Console.ReadLine());

        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        int sum = a + b + c + d;
        Console.WriteLine($"Sum of all digits is: {sum}");
        Console.WriteLine($"Reverse of digits is: {d}{c}{b}{a}");
        Console.WriteLine($"Swapped second and third digits: {a}{c}{b}{d}");
    }
}

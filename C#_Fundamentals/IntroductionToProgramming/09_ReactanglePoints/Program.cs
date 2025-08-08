
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a value of x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value of y:");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = x * x + y * y <= 25;
        bool isReactangle = x >= -1 && x <= 5 && y >= 1 && y <= 5;
        bool result = inCircle && !isReactangle;

        Console.WriteLine($"Is point in circle and outside the reactangle? {result}");
    }
} 

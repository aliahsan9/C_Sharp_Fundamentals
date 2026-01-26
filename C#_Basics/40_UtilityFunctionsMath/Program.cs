using System;

class MathUtility
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero error!");
            return 0;
        }
        else
        {
            return (double)a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition: " + MathUtility.Add(2, 3));
            Console.WriteLine("Subtration: " + MathUtility.Subtract(5, 4));
            Console.WriteLine("Division: " + MathUtility.Divide(10, 5));
            Console.WriteLine("Multiplcation: " + MathUtility.Multiply(10, 5));
        }
    }
}
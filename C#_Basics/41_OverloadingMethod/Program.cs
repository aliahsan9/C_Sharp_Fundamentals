using System;

class MathUtility
{
   public static int Add(int a, int b)
    {
        return a + b;
    }
   public static double Add(double a, double b)
    {
        return a + b;
    }
   public static int Add(int a, int b, int c)
    {
        return a + b + c; 
    }
}
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Two Integers:" + MathUtility.Add(3, 4));
        Console.WriteLine("Two Doubles:" + MathUtility.Add(3.5, 6.5));
        Console.WriteLine("Three Integers:" + MathUtility.Add(3, 4, 5));
    }
}
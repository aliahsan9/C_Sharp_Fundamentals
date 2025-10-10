using System;
class Program
{
    static int SumOfDigits(int n)
    {
        if (n == 0)
            return 0;
        else
            return (n % 10) + SumOfDigits(n / 10);
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter any digit:");
        int n = int.Parse(Console.ReadLine());

        int result = SumOfDigits(n);
        Console.WriteLine(result);
    }
}
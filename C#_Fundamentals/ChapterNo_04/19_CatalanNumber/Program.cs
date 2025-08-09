using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter n (n ≥ 0): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("n must be ≥ 0.");
            return;
        }

        BigInteger catalan = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine($"Catalan number C({n}) = {catalan}");
    }

    static BigInteger Factorial(int num)
    {
        BigInteger result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}

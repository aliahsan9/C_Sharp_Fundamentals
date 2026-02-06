using System;

class Solution
{
    // Make it static for easy calling
    public static bool ThreeDivisors(int num)
    {
        int sqrt = (int)Math.Sqrt(num);

        // If not perfect square, cannot have exactly 3 divisors
        if (sqrt * sqrt != num)
            return false;

        return IsPrime(sqrt);
    }

    // Helper function to check prime
    public static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int num = 9;
        bool result = Solution.ThreeDivisors(num);

        Console.WriteLine($"Does {num} have exactly 3 divisors? {result}");
    }
}

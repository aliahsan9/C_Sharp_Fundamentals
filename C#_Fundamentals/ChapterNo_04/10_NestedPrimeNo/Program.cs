using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value of n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of m:");
        int m = int.Parse(Console.ReadLine());

        for (int num = n; num <= m; num++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);

            while (divider <= maxDivider)
            {
                if (num % divider == 0)
                {
                    prime = false;
                    break;
                }
                divider++;
            }

            if (prime && num > 1) // also check num > 1 for prime numbers
            {
                Console.WriteLine(num);
            }
        }
    }
}

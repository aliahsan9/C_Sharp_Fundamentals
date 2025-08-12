using System;

class Program
{
    // Function to find GCD using Euclidean algorithm
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a); // GCD is always positive
    }
 
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine().Trim());

        int gcd = FindGCD(num1, num2);
        int lcm = Math.Abs(num1 * num2) / gcd; // LCM formula

        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }
}

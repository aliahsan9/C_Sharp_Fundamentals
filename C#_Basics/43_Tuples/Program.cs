using System;

class Program
{
    // Method returning multiple values using a tuple
    static (int sum, int product) Calculate(int a, int b)
    {
        int sum = a + b;
        int product = a * b;

        return (sum, product);
    }
    static void Main(string[] args)
    {
        // Call the method
        var result = Calculate(3, 4);
        Console.WriteLine("Sum: "+ result.sum);
        Console.WriteLine("Product: "+ result.product);
    }
}
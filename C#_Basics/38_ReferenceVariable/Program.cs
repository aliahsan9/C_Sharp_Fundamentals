using System;

class Program
{
    // Method using ref
    static void DoubleRef(ref int number)
    {
        number = number * 2;
    }

    // Method using out
    static void GetSumAndProduct(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }

    static void Main()
    {
        // ----------- ref demonstration -----------
        int num = 5;
        Console.WriteLine("Before ref method: " + num);

        DoubleRef(ref num); // pass using ref
        Console.WriteLine("After ref method: " + num);

        // ----------- out demonstration -----------
        int x = 4, y = 6;
        int sumResult, productResult;

        GetSumAndProduct(x, y, out sumResult, out productResult); // pass using out
        Console.WriteLine($"Sum: {sumResult}, Product: {productResult}");
    }
}

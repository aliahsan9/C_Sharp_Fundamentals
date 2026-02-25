using System;
using System.Runtime.InteropServices;

public delegate int MyDelegate(int a, int b);

public class Calculator
{
    // Method: 1
    public int Add(int x, int y)
    {
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        return x * y;
    }
}
class Program
{
    static void Main(String[] args)
    {
        Calculator calc = new Calculator();

        // Create a new Delegate
        MyDelegate del;

        del = calc.Add;
        int result1 = del(5, 10);

        Console.WriteLine("Sum is: " + result1);


        del = calc.Multiply;
        int result2 = del(5, 10);
        Console.WriteLine("Multiplication Result:" + result2);
    }
}

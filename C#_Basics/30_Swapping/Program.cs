using System;

class Swapping
{
    static void Main(string[] args)
    {
        int a = 5, b = 10;
        a = a + b; // 5 + 10 = 15
        b = a - b; // 15 - 10 = 5
        a = a - b; // 15 - 5 = 10
        Console.Write($"a is: {a} and b is: {b}");
    }
}
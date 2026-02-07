using System;

class Program
{ 
    public static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
    static void Main(string[] args)
    {
        int x = 5, y = 10;

        Console.WriteLine($"Before Swapping: x = {x}, y = {y}");

        Swap<int>(ref x, ref y);

        Console.WriteLine($"After Swapping: x = {x}, y = {y}");
    }
}
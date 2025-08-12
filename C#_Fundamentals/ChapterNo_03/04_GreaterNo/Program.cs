using System;

class Program
{
    public static void Main(string[]args)
    {
    int num1 = 6;
    int num2 = 2;
       Console.WriteLine($"num1 before swapping is: {num1}");
       Console.WriteLine($"num2 before swapping is: {num2}");
    if(num1 > num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"num1 after swapping is: {num1}");
        Console.WriteLine($"num2 after swapping is: {num2}");
    }
}
}

using System;

class Program
{
    public static void Main(string[] args)
    {
        int number = 2;
        Console.WriteLine("First 100 integers, with 3rd integer is negative are: ");

for(int i = 1; i <= 100; i++)
{
    //Every third integer starting from 4 should be negative
    if((i - 1) % 3 == 0 && i !=1)
    {
        Console.Write(-number + " ");
    }
    else
    {
        Console.Write(number+ " ");
    }
    number++;

    if(i % 10 == 0)
    {
        Console.WriteLine();
    }
}
    }
}
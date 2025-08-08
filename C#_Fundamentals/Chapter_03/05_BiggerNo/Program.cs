using System;

class Program
{
    public static void Main(string[]args)
    {
        int num1 = 6, num2 = 4, num3 = 5;
       if(num1 > num2)
       {
        if(num1 > num3)
        {
            Console.WriteLine($"Biggest number is: {num1}");
        }
       }
       if(num2 > num1)
       {
        if(num2 > num3)
        {
            Console.WriteLine($"Biggest number is: {num2}");
        }
       }
       else
       if(num3 > num1)
       {
        if(num3 > num2)
        {
      Console.WriteLine($"Biggest number is: {num3}");
        }
       }
    }
}
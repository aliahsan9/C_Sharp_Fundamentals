using System;

class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter any positive integer:");
        int num = int.Parse(Console.ReadLine());

        int divider = 2;
        int maxDivider = (int)Math.Sqrt(num);
        bool prime = true;
        if(prime && (divider <= maxDivider))
        {
            if(num % divider == 0){

            prime = false;
            }
        divider++;
        }
        Console.WriteLine("Prime: "+ prime);
    }
}
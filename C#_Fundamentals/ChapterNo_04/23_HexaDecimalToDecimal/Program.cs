using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any HexaDecimal number:");
        string HexaDecimal = Console.ReadLine().Trim();

        try
        {
            int decimalNumber = Convert.ToInt32(HexaDecimal, 16);
            Console.WriteLine($"Decimal of given HexaDecimal is: {decimalNumber}");
        }
        catch
        {
            Console.WriteLine("Invalid Input!");
        }
    }

}   
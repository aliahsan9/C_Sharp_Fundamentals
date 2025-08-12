using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine().Trim());

        try
        {
            string hexaDecimal = Convert.ToString(decimalNumber, 16).ToUpper();
            Console.WriteLine($"HexaDecimal of given Decimal is: {hexaDecimal}");
        }
        catch
        {
            Console.WriteLine("Invalid Input!");
        }
    }
} 
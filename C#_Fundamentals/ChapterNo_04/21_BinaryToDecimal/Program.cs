using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter any binary numbers:");
    string binaryNumber = Console.ReadLine().Trim();

    try
    {
      int decimalNumber = Convert.ToInt32(binaryNumber, 2);
      Console.WriteLine($"Decimal of given binary number is: {decimalNumber}");
    }
    catch
    {
      Console.WriteLine("InValid Input!");
    }
  }
}
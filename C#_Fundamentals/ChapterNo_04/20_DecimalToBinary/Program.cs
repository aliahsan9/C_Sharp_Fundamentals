using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // Convert decimal to binary using built-in method
        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine("Binary representation: " + binaryNumber);
    }
}

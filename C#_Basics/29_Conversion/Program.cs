using System;

class Program
{
    static void Main()
    {
        // INT conversion
        Console.Write("Enter an integer: ");
        string intInput = Console.ReadLine();

        if (int.TryParse(intInput, out int intValue))
            Console.WriteLine($"Integer value: {intValue}");
        else
            Console.WriteLine("Invalid integer input");

        // DOUBLE conversion
        Console.Write("\nEnter a double value: ");
        string doubleInput = Console.ReadLine();

        if (double.TryParse(doubleInput, out double doubleValue))
            Console.WriteLine($"Double value: {doubleValue}");
        else
            Console.WriteLine("Invalid double input");

        // DATETIME conversion
        Console.Write("\nEnter a date (e.g. 2025-01-25): ");
        string dateInput = Console.ReadLine();

        if (DateTime.TryParse(dateInput, out DateTime dateValue))
            Console.WriteLine($"Date value: {dateValue}");
        else
            Console.WriteLine("Invalid date input");
    }
}

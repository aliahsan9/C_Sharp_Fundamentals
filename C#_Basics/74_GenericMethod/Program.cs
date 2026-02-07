using System;

class Program
{
    public static void PrintValue<T>(T value)
    {
          Console.WriteLine("Value is:"+ value);    
    }  
    static void Main(string[] args)
        {
        // Printing Integer value

        PrintValue<int>(12);

        // Printing String value
        PrintValue<string>("Hello");

        // Printing double value
        PrintValue<double>(3.14);

        // Printing boolean value
        PrintValue<bool>(true);
        }
}
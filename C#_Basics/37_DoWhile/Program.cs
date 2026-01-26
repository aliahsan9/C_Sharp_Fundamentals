using System;
using System.Security.Cryptography;

class MenuDriven
{
    static void Main(String[] args)
    {
        int choice = 0;
        do
        {
            // Menu
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Add Two numbers:");
            Console.WriteLine("2. Subtract Two numbes:");
            Console.WriteLine("3. Multiply Two numbers:");
            Console.WriteLine("4. Exit!");

            // Read Choice
            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a1:");
                    int a1 = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Enter b1:");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {a1 + b1}");
                    break;

                case 2:
                    Console.WriteLine("Enter a2:");
                    int a2 = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Enter b2:");
                    int b2 = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine($"Result: {a2 - b2}");
                    break;

                case 3:
                    Console.WriteLine("Enter a3:");
                    int a3 = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Enter b3");
                    int b3 = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine($"Result: {a3 * b3}");
                    break;

                case 4:
                    Console.WriteLine("Exiting!");
                    break;

                default:
                    Console.WriteLine("InValid Input!");
                    break;

            }
        }
        while (choice != 4);
    }
}
using System;

class Program
{
    public static void Main(string[]args)
{
    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter your address:");
    string address = Console.ReadLine();
    Console.WriteLine("Enter phone number:");
    int phone = int.Parse(Console.ReadLine());

    Console.WriteLine($"{name} belongs to {address} and his phone no. is {phone}");

}
} 
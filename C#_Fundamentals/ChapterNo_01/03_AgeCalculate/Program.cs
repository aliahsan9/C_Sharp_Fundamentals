using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Age:");
      string input = Console.ReadLine();


      int age = int.Parse(input);
      int ageAfterTenYears = age + 10;

      Console.WriteLine($"Your age after 10 years will be: {ageAfterTenYears}");
    }
}

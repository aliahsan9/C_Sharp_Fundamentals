using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a height of reactangle:");
        double Length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a width of a reactangle:");
        double width = double.Parse(Console.ReadLine());

        double perimeter = 2 * (Length + width);
        double area = Length * width;
        Console.WriteLine($"Area of a reactangle is {area}");
        Console.WriteLine($"Perimeter of a reactangle is {perimeter}");
    }
}

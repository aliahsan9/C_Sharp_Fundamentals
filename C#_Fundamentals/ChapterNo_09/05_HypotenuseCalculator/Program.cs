using System;

class HypotenuseCalculator
{
    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter the length of side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        // Hypotenuse formula: √(a² + b²)
        double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        // Output result
        Console.WriteLine("The hypotenuse of the triangle is: " + hypotenuse);
    }
}

using System;

class TemperatureConverter
{
    // Method to convert Fahrenheit to Celsius
    static double ConvertFahrenheitToCelsius(double temperatureF)
    {
        // Formula: (Fahrenheit - 32) × 5 / 9
        double temperatureC = (temperatureF - 32) * 5 / 9;
        return temperatureC; // Return the converted Celsius value
    }

    static void Main()
    {
        // Ask the user to enter temperature in Fahrenheit
        Console.Write("Enter your body temperature in Fahrenheit degrees: ");

        // Read input from user and convert it to double
        double temperature = double.Parse(Console.ReadLine());

        // Convert Fahrenheit temperature to Celsius
        temperature = ConvertFahrenheitToCelsius(temperature);

        // Display the result
        Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);

        // Check if the person has a fever (temperature ≥ 37°C)
        if (temperature >= 37)
        {
            Console.WriteLine("You are ill!");
        }
    }
}

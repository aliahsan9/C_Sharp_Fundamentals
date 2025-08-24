using System;

class DataValidation
{
    static void Main()
    {
        // Ask the user for the current time
        Console.WriteLine("What time is it?");

        // Input for hours
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine()); // Read and convert input to int

        // Input for minutes
        Console.Write("Minutes: ");
        int minutes = int.Parse(Console.ReadLine()); // Read and convert input to int

        // Validate both hours and minutes
        bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);

        // If both are valid, display the time
        if (isValidTime)
        {
            Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
        }
        else
        {
            // Otherwise, show error message
            Console.WriteLine("Incorrect time!");
        }
    }

    // Method to validate hours (0–23)
    static bool ValidateHours(int hours)
    {
        bool result = (hours >= 0) && (hours < 24);
        return result;
    }

    // Method to validate minutes (0–59)
    static bool ValidateMinutes(int minutes)
    {
        bool result = (minutes >= 0) && (minutes <= 59);
        return result;
    }
}

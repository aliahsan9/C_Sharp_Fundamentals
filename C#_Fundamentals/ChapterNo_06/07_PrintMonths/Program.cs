using System;

class Months
{
    // Method to get the name of a month based on its number
    static string GetMonthName(int month)
    {
        string monthName;

        // Switch statement maps month number to month name
        switch (month)
        {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                // Invalid month number
                Console.WriteLine("Invalid month!");
                return null; // No valid month name
        }

        return monthName;
    }

    // Method to calculate and display the period (in months) between two months
    static void SayPeriod(int startMonth, int endMonth)
    {
        int period = endMonth - startMonth;

        // If result is negative, adjust by adding 12 (to handle wrap-around)
        if (period < 0)
        {
            period = period + 12;
        }

        // Display the result
        Console.WriteLine(
            "There is {0} months period from {1} to {2}.",
            period, GetMonthName(startMonth),
            GetMonthName(endMonth)
        );
    }

    // Main method - Entry point of the program
    static void Main()
    {
        // Get first month number from user
        Console.Write("First month (1-12): ");
        int firstMonth = int.Parse(Console.ReadLine());

        // Get second month number from user
        Console.Write("Second month (1-12): ");
        int secondMonth = int.Parse(Console.ReadLine());

        // Calculate and display the period
        SayPeriod(firstMonth, secondMonth);
    }
}

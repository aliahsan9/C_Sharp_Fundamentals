using System;

class Today
{
    public string PrintToday()
    {
        DayOfWeek today = DateTime.Now.DayOfWeek; // fixed typo
        return today.ToString();
    }

    static void Main(string[] args)
    {
        Today todayDay = new Today();
        Console.WriteLine("Today is: " + todayDay.PrintToday());
    }
}

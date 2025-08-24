using System;

class Uptime
{
    static void Main(string[] args)
    {
        // Get milliseconds since system started
        long milliseconds = Environment.TickCount64;

        // Convert to TimeSpan for easy calculation
        TimeSpan uptime = TimeSpan.FromMilliseconds(milliseconds);

        Console.WriteLine("Time since computer started:");
        Console.WriteLine($"Days   : {uptime.Days}");
        Console.WriteLine($"Hours  : {uptime.Hours}");
        Console.WriteLine($"Minutes: {uptime.Minutes}");
    }
}

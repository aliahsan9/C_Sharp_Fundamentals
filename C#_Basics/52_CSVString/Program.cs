using System;


class Program
{
    static void Main(string[] args)
    {
        string csv = "Ali, 25, Developer, Karachi";

        // Split the CSV string
        string[] values = csv.Split(',');

        Console.WriteLine("Name: " + values[0]);
        Console.WriteLine("Age: " + values[1]);
        Console.WriteLine("Profession: " + values[2]);
        Console.WriteLine("City: " + values[3]);

    }
}
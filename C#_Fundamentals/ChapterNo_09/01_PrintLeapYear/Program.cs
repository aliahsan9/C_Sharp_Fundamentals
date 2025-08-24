using System;

class LeapYear
{
  public string PrintLeapYear(int year)
  {
    if (year % 4 == 0)
    {
      return "Leap Year";
    }
    return "Not a Leap Year!";
  }

  public static void Main(string[] args)
  {
    Console.WriteLine("Enter any year to check either it is leap or not:");
    int year = int.Parse(Console.ReadLine());

    //Make an object 
    LeapYear leap = new LeapYear();

    string result = leap.PrintLeapYear(year);
    Console.WriteLine($"{year} is a {result}");
  }
}
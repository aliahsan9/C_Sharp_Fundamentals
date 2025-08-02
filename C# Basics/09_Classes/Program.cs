using System;

public class Student
{
    public string Name;
    public int Age;
    public string Address;

    public void GetInput()
    {
        Console.WriteLine("Enter a Name:");
        Name = Console.ReadLine();

        Console.WriteLine("Enter an Age:");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter an Address:");
        Address = Console.ReadLine();
    }

    public void GetOutput()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Address: " + Address);
    }

    public static void Main(string[] args)
    {
        Student s = new Student();
        s.GetInput();
        s.GetOutput();
    }
}

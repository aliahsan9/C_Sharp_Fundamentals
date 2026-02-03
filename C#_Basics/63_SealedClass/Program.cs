using System;

class Teacher
{
    // Fields

    public string Name;
    public int Id;
    public string City;

    // Parameterized Constructor

    public Teacher(string name, int id, string city)
    {
        Name = name;
        Id = id;
        City = city;
    }
    // Method to Display Info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id} and City: {City}");
    }
}

// Sealed prevents further inheritance
sealed class Student: Teacher
{
    // Student constructor calls base (Teacher) constructor
    public Student(string name, int id, string city)
        : base(name, id, city)  // Correct way
    {

    }
}

class Program
{
    static void Main(String[] args)
    {

        // Creating Teacher Object
        Teacher t = new Teacher("Ali Ahsan", 101, "PirMahal");

        t.DisplayInfo();

        // Creating Student Object
        Student s = new Student("Asim", 102, "Lahore");

        t.DisplayInfo();
    }
}
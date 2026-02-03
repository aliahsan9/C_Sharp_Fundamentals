using System;

sealed class Student
{
    private readonly string _name;
    private readonly int _id;
    private readonly string _city;

    // Constructor
    public Student(string name, int id, string city)
    {
        _name = name;
        _id = id;
        _city = city;
    }
    // Getters method
    public string Name
    {
        get { return _name; }
    }
    public int Id
    {
        get { return _id; }
    }
    public string City
    {
        get { return _city; }
    }
    // Display info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, City: {City}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating immutable object
        Student s = new Student("Ali Ahsan", 101, "Lahore");
        s.DisplayInfo();
    }
}
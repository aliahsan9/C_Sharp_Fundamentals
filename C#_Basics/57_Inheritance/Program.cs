using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    // Constructor
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    // Display Employee Info
    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee's Id: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public string Department;
    public double Bonus;

    // Derived Class Constructor
    public Manager(int id, string name, double salary, string department, double bonus)
        : base(id, name, salary)
    {
        Department = department;
        Bonus = bonus;
    }

    public void DisplayManager()
    {
        DisplayEmployee(); // inherited method
        Console.WriteLine($"Manager's Department: {Department}, Bonus: {Bonus}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager(101, "Ali Ahsan", 80000, "IT", 20000);
        m.DisplayManager();
    }
}

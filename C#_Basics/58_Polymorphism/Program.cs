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

    // Virtual method: can be overridden by derived classes
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Employee's Id: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public string Department;
    public double Bonus;

    // Constructor for Manager, calling Employee constructor
    public Manager(int id, string name, double salary, string department, double bonus)
        : base(id, name, salary)
    {
        Department = department;
        Bonus = bonus;
    }

    // Override the base class method
    public override void DisplayInfo()
    {
        // First, call the base class version (optional)
        base.DisplayInfo();

        // Then add Manager-specific info
        Console.WriteLine($"Manager's Department: {Department}, Bonus: {Bonus}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee e = new Employee(100, "Ali", 50000);
        e.DisplayInfo();  // Calls Employee's DisplayInfo

        Console.WriteLine();

        // Create a Manager object
        Manager m = new Manager(101, "Ahsan", 80000, "IT", 20000);
        m.DisplayInfo();  // Calls Manager's DisplayInfo (overridden)
    }
}

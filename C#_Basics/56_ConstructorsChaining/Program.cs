using System;

class Person
{
    public string Name;
    public int Age;
    public string City;

    // Default constructor
    public Person() : this("Ali", 22, "Lahore")
    {
    }

    // Constructor with 2 parameters
    public Person(string name, int age) : this(name, age, "Unknown")
    {
    }

    // Main constructor
    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Person p2 = new Person("Akram", 34);
        Person p3 = new Person("Ajmal", 35, "PirMahal");
    }

}

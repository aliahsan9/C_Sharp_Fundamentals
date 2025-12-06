using System;

// Base class (Parent)
class Animal
{
    public string name;

    // Method of base class
    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }
}

// Derived class (Child) that inherits from Animal
class Dog : Animal
{
    // Method specific to Dog class
    public void Bark()
    {
        Console.WriteLine($"{name} is barking.");
    }
}

// Program to demonstrate inheritance
class Program
{
    static void Main(string[] args)
    {
        // Create an object of the derived class
        Dog myDog = new Dog();

        // Assign value to the inherited field
        myDog.name = "Tommy";

        // Call method from the base class
        myDog.Eat();

        // Call method from the derived class
        myDog.Bark();
    }
}

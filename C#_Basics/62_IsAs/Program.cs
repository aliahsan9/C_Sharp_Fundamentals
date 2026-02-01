using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Another derived class
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

class Program
{
    static void Main()
    {
        // Base class reference pointing to a Dog object (upcasting)
        Animal animal = new Dog();

        // --------------------------------------------------
        // USING 'is' OPERATOR
        // --------------------------------------------------
        // 'is' checks the object type AND safely casts it
        if (animal is Dog dog)
        {
            // This block runs only if 'animal' is actually a Dog
            dog.Bark();
        }

        // Checking for a different type
        if (animal is Cat)
        {
            // This will NOT execute because animal is not a Cat
            Console.WriteLine("Animal is a Cat");
        }
        else
        {
            Console.WriteLine("Animal is NOT a Cat");
        }

        // --------------------------------------------------
        // USING 'as' OPERATOR
        // --------------------------------------------------
        // 'as' tries to cast and returns null if casting fails
        Dog dogUsingAs = animal as Dog;

        if (dogUsingAs != null)
        {
            // Casting succeeded now
            dogUsingAs.Bark();
        }

        // Attempting to cast Animal (Dog) into Cat using 'as'
        Cat catUsingAs = animal as Cat;

        if (catUsingAs == null)
        {
            // Casting failed, no exception thrown
            Console.WriteLine("Casting to Cat failed using 'as'");
        }

        // --------------------------------------------------
        // WHAT NOT TO DO (UNSAFE DOWNCASTING)
        // --------------------------------------------------
        // This would throw an InvalidCastException at runtime:
        // Cat unsafeCat = (Cat)animal;
    }
}

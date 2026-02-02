using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        // ---------------------------
        // UPCASTING
        // ---------------------------
        Dog myDog = new Dog();

        // Implicit upcasting (Dog -> Animal)
        Animal animalRef = myDog;

        Console.WriteLine("Upcasting:");
        animalRef.Eat();   // Works
        // animalRef.Bark(); ❌ Not allowed (Animal reference)

        // ---------------------------
        // DOWNCASTING
        // ---------------------------
        Console.WriteLine("\nDowncasting:");

        // Explicit downcasting (Animal -> Dog)
        Dog dogRef = (Dog)animalRef;

        dogRef.Bark(); // Works

        // -------------------------
        // SAFE DOWNCASTING with 'is'

        Console.WriteLine("\nSafe Downcasting using 'is':");

        if (animalRef is Dog safeDog)
        {
            safeDog.Bark();
        }

        // SAFE DOWNCASTING with 'as'
      
        Console.WriteLine("\nSafe Downcasting using 'as':");

        Dog anotherDog = animalRef as Dog;

        if (anotherDog != null)
        {
            anotherDog.Bark();
        }
    }
}

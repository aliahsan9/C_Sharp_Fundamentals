//Data abstraction is the process of hiding certain details and showing only essential information to the user.

using System;

abstract class Animal {

    public abstract void AnimalSound();

public void Sleep(){
    Console.WriteLine("Zzzz...");
}

}
class Pig : Animal {
    public override void AnimalSound(){
        Console.WriteLine("The Pig says We we...");
    }
} 
class Program{

    static void Main(string[] args){

        Animal animal = new Pig();
        Pig pigAnimal = new Pig();
        animal.Sleep();
        pigAnimal.AnimalSound();
    }
}
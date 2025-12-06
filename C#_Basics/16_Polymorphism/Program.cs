using System;

 class Animal{
    public virtual void animalSound(){
        Console.WriteLine("The Animal makes a Sound!");
    }
}
class Pig : Animal{
    
    public override void animalSound(){
        Console.WriteLine("The Pig says Wee Wee Wee!");
    }
}

class Cat : Animal{ 
    public override void animalSound(){
        Console.WriteLine("The Cat says Meo Meo!");
    }
}
class Hen : Animal{
    public override void animalSound(){
        Console.WriteLine("The Hen says Kuck kuck!");
    }
}
class Dog : Animal{
    public override void animalSound(){
        Console.WriteLine("The Dog says Wou wou!");
    }
}

class Program{
    static void Main(string [] args){
        Animal animal = new Animal();
       Pig pigAnimal = new Pig();
       Cat catAnimal = new Cat();
       Hen henAnimal = new Hen();
         Dog dogAnimal = new Dog();
        animal.animalSound();
        pigAnimal.animalSound();
        catAnimal.animalSound();
        henAnimal.animalSound();
        dogAnimal.animalSound();
    }
}
using System;

class Program {
    static void Main(string [] args){

        Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        string response = "How are you " + name;

        Console.WriteLine("Hello " + name +", "+ response + ".");
    }
}
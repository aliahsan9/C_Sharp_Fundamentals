using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(String[] args)
    {
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Orange",
            "Banana"
        };
        // Create a readonly collection from the list
        ReadOnlyCollection<string> readonlyfruits = 
            new ReadOnlyCollection<string>(fruits);

       // Display items from the readonly list
       foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
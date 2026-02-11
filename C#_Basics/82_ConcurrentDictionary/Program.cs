using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        // Thread safe Dictionary
        ConcurrentDictionary<int, string> users = new ConcurrentDictionary<int, string>();

        // Safely add a key value pair
        bool added = users.TryAdd(1, "Ali Ahsan");
        Console.WriteLine("Added User1: " + added);

        // Now adding duplicate values
        // TryAdd gets fail if key is already exist in ConcurrentDictionary
        added = users.TryAdd(1, "Ahmad");
        Console.WriteLine("Added Duplicate Value: " + added);

        // Safely get a Value
        if(users.TryGetValue(1, out string name))
        {
            Console.WriteLine("User1 name is: " + name);
        }
    }
}
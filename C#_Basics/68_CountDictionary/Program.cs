using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "hello world hello dotnet world";

        // Dictionary to store word frequency
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Split text into words
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            // Convert to lowercase to avoid case issues
            string key = word.ToLower();

            // If word already exists, increase count
            if (wordCount.ContainsKey(key))
            {
                wordCount[key]++;
            }
            // Otherwise, add new word with count = 1
            else
            {
                wordCount.Add(key, 1);
            }
        }

        // Print result
        Console.WriteLine("Word Frequency:");
        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

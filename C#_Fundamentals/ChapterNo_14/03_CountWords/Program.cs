using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        // Step 1: Read text from file
        string filePath = "words.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string text = File.ReadAllText(filePath);

        // Step 2: Convert to lowercase for case-insensitive comparison
        text = text.ToLower();

        // Step 3: Extract words (ignore punctuation)
        string[] words = Regex.Split(text, @"\W+"); // split by non-word characters

        // Step 4: Count occurrences of each word
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (string.IsNullOrWhiteSpace(word))
                continue;

            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // Step 5: Sort words by number of occurrences (ascending)
        var sorted = wordCount.OrderBy(w => w.Value);

        // Step 6: Display results
        Console.WriteLine("Word Occurrences (ordered by count):");
        foreach (var item in sorted)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

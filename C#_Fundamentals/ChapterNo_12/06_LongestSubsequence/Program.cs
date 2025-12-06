using System;
using System.Collections.Generic;

class LongestEqualSubsequence
{
    // Method to find the longest subsequence of equal numbers
    public static List<int> FindLongestEqualSubsequence(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return new List<int>();

        int maxCount = 1;
        int currentCount = 1;
        int number = numbers[0];
        int bestNumber = number;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                bestNumber = numbers[i];
            }
        }

        // Build the longest subsequence
        List<int> result = new List<int>();
        for (int i = 0; i < maxCount; i++)
        {
            result.Add(bestNumber);
        }

        return result;
    }

    // Main method to test
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 1, 2, 3, 3, 3, 2, 2, 2, 2, 1 };
        
        List<int> longestSeq = FindLongestEqualSubsequence(numbers);

        Console.WriteLine("Input List: " + string.Join(", ", numbers));
        Console.WriteLine("Longest subsequence of equal numbers: " + string.Join(", ", longestSeq));
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        // Dictionary to store element frequencies
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count the frequency of each element
        foreach (int num in arr)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        int mostFrequent = arr[0];
        int maxCount = 0;

        // Find the element with the highest frequency
        foreach (var pair in frequencyMap)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostFrequent = pair.Key;
            }
        }

        Console.WriteLine($"Most frequent element: {mostFrequent} ({maxCount} times)");
    }
}

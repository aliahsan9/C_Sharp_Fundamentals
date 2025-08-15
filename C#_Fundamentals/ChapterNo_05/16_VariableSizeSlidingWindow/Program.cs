using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "abcabcbb";
        Console.WriteLine("Length of longest substring without repeating characters: " + LongestUniqueSubstring(str));
    }

    static int LongestUniqueSubstring(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int start = 0, maxLength = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (map.ContainsKey(s[end]))
                start = Math.Max(start, map[s[end]] + 1);

            map[s[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}

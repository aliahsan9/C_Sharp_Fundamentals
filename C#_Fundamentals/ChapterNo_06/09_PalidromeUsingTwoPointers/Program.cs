using System;

class Program
{
    static bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome("madam")); // True
        Console.WriteLine(IsPalindrome("hello")); // False
    }
}

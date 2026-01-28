using System;

class CheckAnagrams
{
    public static bool isAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        // Sort both Strings
        char[] s1Array = s1.ToCharArray();
        char[] s2Array = s2.ToCharArray();
        Array.Sort(s1Array);
        Array.Sort(s2Array);

        // Compare Strings
        return new string (s1Array) == new string (s2Array);
    }
}
class Program
{
    static void Main(String[] args)
    {
        string s1 = "geeks";
        string s2 = "skeeg";

        bool result = CheckAnagrams.isAnagram(s1, s2);
        if(result)
        {
            Console.WriteLine("Strings are Anagrams");
        }
        else
        {
            Console.WriteLine("Strings are Not Anagrams.");
        }
    }
}
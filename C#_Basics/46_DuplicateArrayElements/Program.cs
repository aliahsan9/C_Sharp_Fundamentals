using System;
using System.Collections.Generic;

class DuplicateElements
{
     public static void FindDuplicates(int[] array)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicate = new HashSet<int>();

        foreach(int num in array)
        {
            if(!seen.Add(num))
            {
                duplicate.Add(num);
            }
        }
        Console.WriteLine("Duplicate Elements are:");
        foreach(int d in duplicate)
        {
            Console.WriteLine(d); 
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8};
        DuplicateElements.FindDuplicates(array);
    }
}
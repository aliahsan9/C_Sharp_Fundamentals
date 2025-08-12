using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first word:");
        char[] firstArray = Console.ReadLine().ToCharArray();

        Console.WriteLine("Enter the second word:");
        char[] secondArray = Console.ReadLine().ToCharArray();

        int minLength = Math.Min(firstArray.Length, secondArray.Length);
        bool areEqual = true;

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First array comes before second array lexicographically.");
                areEqual = false;
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Second array comes before first array lexicographically.");
                areEqual = false;
                break;
            }
        }

        if (areEqual)
        {
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("First array comes before second array lexicographically.");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Second array comes before first array lexicographically.");
            }
            else
            {
                Console.WriteLine("Both arrays are equal.");
            }
        }
    }
}
 
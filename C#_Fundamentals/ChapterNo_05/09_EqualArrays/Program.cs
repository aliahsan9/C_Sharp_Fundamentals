using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of first array:");
        int firstSize = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstSize];

        Console.WriteLine("Enter the elements in the first array:");
        for(int i = 0; i < firstSize; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the size of second array:");
        int secondSize = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondSize];
        Console.WriteLine("Enter the elements in the second array:");
        for(int j = 0; j < secondSize; j++)
        {
            secondArray[j] = int.Parse(Console.ReadLine());
        }
        if(firstSize != secondSize)
        {
            Console.WriteLine("both arrays are not equal!");
            return;
        }
        bool areEqual = true;
        for(int k = 0; k < firstSize; k++)
        {
            if(firstArray[k] != secondArray[k])
            {
                areEqual = false;
                break;
            }
        }
        if(areEqual)
        {
            Console.WriteLine("Both arrays are equal, with equal elements.");
        }
        else
        {
            Console.WriteLine("Both elements are not, equal!");
        }
    }
}
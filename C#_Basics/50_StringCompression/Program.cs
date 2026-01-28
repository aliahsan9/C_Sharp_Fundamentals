using System;
using System.Text;

class StringCompression
{
    public static string CompressString(string input)
    {
        // Edge case: empty string
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder compressed = new StringBuilder();

        int count = 1;

        // Loop through the string
        for (int i = 1; i < input.Length; i++)
        {
            // If current character is same as previous, increase count
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                // Append previous character and its count
                compressed.Append(input[i - 1]);
                compressed.Append(count);

                // Reset count for new character
                count = 1;
            }
        }

        // Append the last character and its count
        compressed.Append(input[input.Length - 1]);
        compressed.Append(count);

        return compressed.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        string input = "aaabb";

        string result = StringCompression.CompressString(input);

        Console.WriteLine("Compressed string: " + result);
    }
}

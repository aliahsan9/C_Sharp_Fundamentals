using System;

class SubstringCounterTwoPointer
{
    public static int CountOccurrences(string text, string substring)
    {
        int count = 0;

        for (int i = 0; i <= text.Length - substring.Length; i++)
        {
            int j = 0;

            // Compare characters one by one
            while (j < substring.Length && text[i + j] == substring[j])
            {
                j++;
            }

            if (j == substring.Length) // full match found
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        string text = @"We are living in a yellow submarine. 
                        We don't have anything else. 
                        Inside the submarine is very tight. 
                        So we are drinking all the day. 
                        We will move out of it in 5 days.";

        string substring = "in";

        int occurrences = CountOccurrences(text, substring);

        Console.WriteLine($"The substring \"{substring}\" occurs {occurrences} times.");
    }
}

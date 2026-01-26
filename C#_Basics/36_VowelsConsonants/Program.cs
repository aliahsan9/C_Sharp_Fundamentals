using System;

class VowelsConsonants
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any string:");
        string input = Console.ReadLine();

        int vowels = 0, consonants = 0, digits = 0;

        foreach(char ch in input.ToLower())
        {
            if(char.IsDigit(ch))
            {
                digits++;
            }
            else
                if(ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }
        Console.WriteLine($"Vowels are: {vowels}");
        Console.WriteLine($"Consonants are: {consonants}");
        Console.WriteLine($"Digits are: {digits}");
    }

}
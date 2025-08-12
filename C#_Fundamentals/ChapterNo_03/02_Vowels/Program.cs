using System;

class Program
{
    public static void Main(String[]args)
    {
        char ch = 'o';
        if(ch == 'A' || ch == 'a')
        {
            Console.WriteLine($"Char {ch} is a vowel.");
        }
        else if(ch == 'E' || ch =='e')
        {
            Console.WriteLine($"Char {ch} is vowel.");
        }
        else if(ch == 'I' || ch == 'i')
        {
            Console.WriteLine($"Char {ch} is a vowel.");
        }
        else if(ch == 'O' || ch == 'o')
        {
            Console.WriteLine($"Char {ch} is vowel.");
        }
        else if(ch == 'U' || ch == 'u')
        {
            Console.WriteLine($"Char {ch} is a vowel.");
        }
        else
        {
            Console.WriteLine("Char is Consonant!");
        }
    }
}
using System;
using System.Text;

class RandomPasswordGenerator
{
    // Define sets of characters to be used in password generation
    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string Digits = "0123456789";
    private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
    
    // Combine all sets for generating additional random characters
    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

    // Random number generator
    private static Random rnd = new Random();

    static void Main()
    {
        StringBuilder password = new StringBuilder();

        // Generate 2 random capital letters
        for (int i = 1; i <= 2; i++)
        {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPosition(password, capitalLetter);
        }

        // Generate 2 random small letters
        for (int i = 1; i <= 2; i++)
        {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPosition(password, smallLetter);
        }

        // Generate 1 random digit
        char digit = GenerateChar(Digits);
        InsertAtRandomPosition(password, digit);

        // Generate 3 random special characters
        for (int i = 1; i <= 3; i++)
        {
            char specialChar = GenerateChar(SpecialChars);
            InsertAtRandomPosition(password, specialChar);
        }

        // Generate a few additional random characters (between 0 and 7)
        int count = rnd.Next(8);  // random number between 0 and 7
        for (int i = 1; i <= count; i++)
        {
            char randomChar = GenerateChar(AllChars);
            InsertAtRandomPosition(password, randomChar);
        }

        // Print the final password
        Console.WriteLine("Generated Password: " + password);
    }

    /// <summary>
    /// Inserts a character at a random position inside the password
    /// </summary>
    private static void InsertAtRandomPosition(StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character);
    }

    /// <summary>
    /// Generates a random character from the given set of available characters
    /// </summary>
    private static char GenerateChar(string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }
}
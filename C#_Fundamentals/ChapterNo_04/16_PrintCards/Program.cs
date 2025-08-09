using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", "A" };
        string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };

        foreach (string suit in suits)
        {
            foreach (string face in faces)
            {
                Console.WriteLine($"{face} of {suit}");
            }
        }
    }
}
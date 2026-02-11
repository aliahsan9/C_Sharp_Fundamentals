using System;
using System.Threading;

class program
{
    static void Main(string[] args)
    {
        static void PrintNumbers(){
        for(int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
                Thread.Sleep(500);
        }
       }
        static void PrintLetters()
        {
            for(char c = 'A'; c < 'E'; c++)
            {
                Console.WriteLine(c);
                Thread.Sleep(500);
            }
        }
        PrintLetters();
        PrintNumbers();
    }
}
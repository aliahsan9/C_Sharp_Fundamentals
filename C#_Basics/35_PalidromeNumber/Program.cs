using System;

class Palidrome
{
    public static void CheckPalidrome(int num)
    {
        int originalNum = num;
        int reverse = 0;

        while(num > 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num = num / 10;
        }
        if(originalNum == reverse)
        {
            Console.WriteLine($"{originalNum} is Palidrome.");
        }
        else
        {
            Console.WriteLine($"{originalNum} is Not a Palidrome!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int num = 1232;
        Palidrome.CheckPalidrome(num);
    }
}
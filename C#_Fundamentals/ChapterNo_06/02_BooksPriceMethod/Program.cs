using System;

class Program
{
    static void PrintTotalAmountOfBooks(decimal[] prices)
    {
        decimal totalPrice = 0;

        foreach (decimal singleBookPrice in prices)
        {
            totalPrice += singleBookPrice;
        }
        Console.WriteLine("Total amount of books is:"+ totalPrice);
    }
    public static void Main(string[] args)
    {
        decimal[] bookPrice = {250.9m, 440.9m, 109.9m};
        PrintTotalAmountOfBooks(bookPrice);
    }
}
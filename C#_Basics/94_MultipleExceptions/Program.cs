using System;

class Program
{
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");

            // May throw format exception
            int num = int.Parse(Console.ReadLine());

            // May throw Divide by Zero exception
            int result = 100 / num;

            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Enter an Index(0-2):");

            // May throw format exception again
            int index = int.Parse(Console.ReadLine());
            // May throw indexOutOfRangeException
            Console.WriteLine("Array Value: " + arr[index]);

            Console.WriteLine("Division Result: " + result);
        }
        // Specific Exception First 
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
        // Then format exception
        catch(FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
            Console.WriteLine(ex.Message);
        }
        // Then Index Exception
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Invalid array index.");
            Console.WriteLine(ex.Message);
        }
        // General exception at last
        catch (Exception ex)
        {
            Console.WriteLine("Error: Unexpected Error Occured.");
            Console.WriteLine(ex.Message);
        }
        // Always Executes
        finally
        {
            Console.WriteLine("Program Ended.");
        }
}
}
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");

            // May throw FormatException
            int number = int.Parse(Console.ReadLine());

            // May throw DivideByZeroException
            int result = 100 / number;

            int[] arr = { 10, 20, 30 };

            Console.Write("Enter index (0-2): ");

            // May throw FormatException again
            int index = int.Parse(Console.ReadLine());

            // May throw IndexOutOfRangeException
            Console.WriteLine("Array Value: " + arr[index]);

            Console.WriteLine("Division Result: " + result);
        }

        // 1️⃣ Specific Exception FIRST
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }

        // 2️⃣ Then Format Exception
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
            Console.WriteLine(ex.Message);
        }

        // 3️⃣ Then Index Exception
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Invalid array index.");
            Console.WriteLine(ex.Message);
        }

        // 4️⃣ General Exception at LAST
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error Occurred.");
            Console.WriteLine(ex.Message);
        }

        // Always Executes
        finally
        {
            Console.WriteLine("Program Ended.");
        }
    }
}
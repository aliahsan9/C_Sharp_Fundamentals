using System;
using System.IO;

class Program
{
    static void ReadFile(string fileName)
    {
        try
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadToEnd(); // reads entire file
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("The file '{0}' is not found.", fileName);
        }
        catch (IOException ioe)
        {
            // Exception handler for other input/output exceptions
            Console.WriteLine("An IO Exception occurred:");
            Console.WriteLine(ioe.StackTrace);
        }
    }

    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();
        ReadFile(path);
    }
}

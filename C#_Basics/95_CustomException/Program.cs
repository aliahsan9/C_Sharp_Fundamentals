using System;

// Custom Exception class
public class InvalidMarksException : Exception
{
    // Default Contructor
    public InvalidMarksException()
        : base("Marks are invalid.")
    {

    }
    // Constructor with custom Message
    public InvalidMarksException(string message)
        : base(message)
    {

    }
    // Constructor withh Message + Inner Exception
    public InvalidMarksException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}
  public class StudentService
{
    public void AddMarks(int marks)
    {
        // Business Rule Check
        if(marks < 0 || marks > 100)
        {
            // Throw Rule Check
            throw new InvalidMarksException("Marks must between 0 and 100.");
        }
        Console.WriteLine("Marks added successfully!");
    }
}
class Program
{
    static void Main(String[] args)
    {
        StudentService service = new StudentService();

        try
        {
            service.AddMarks(120); // Invalid marks
        }
        // Catch Custom Exception
        catch (InvalidMarksException ex)
        {
            Console.WriteLine("Custom Error: " + ex.Message);
        }
        // Catch Other Exceptions
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Process Completed.");
        }
    }
}
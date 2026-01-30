using System;
using System.ComponentModel;

public interface ILogger
{
    void Log(string message);
}
public interface ICalculator
{
    int Add(int a, int b);
}

public class UtilityService: ILogger, ICalculator
{
    public void Log(string message)
    {
        Console.WriteLine($"message");
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
}
class Program
{
  static void Main(String[] args)
  {
        UtilityService service = new UtilityService();

        service.Log("Application Started.");
        int result = service.Add(5, 10);

        Console.WriteLine($"Result: {result}");
  }
}

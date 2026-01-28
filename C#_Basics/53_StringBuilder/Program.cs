using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main(String[] args)
    {
        const int iterations = 100_000;

        // -------- String Test ----------
        Stopwatch swString = Stopwatch.StartNew();

        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += i;
        }

        swString.Stop();

        Console.WriteLine($"String Iterations Time: {swString.ElapsedMilliseconds} ms");

        // ------- StringBuilder Test ------------
        Stopwatch swBuilder = Stopwatch.StartNew();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < iterations; i++)
        {
            sb.Append(i);
        }
        string finalResult = sb.ToString();

        swBuilder.Stop();
        Console.WriteLine($"StringBuilder Time: {swBuilder.ElapsedMilliseconds} ms");
    }
}
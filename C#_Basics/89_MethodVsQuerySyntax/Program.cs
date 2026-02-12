using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}
class Program
{
    static void Main()
    {
        // Create list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ali", Score = 85 },
            new Student { Name = "Ahmed", Score = 60 },
            new Student { Name = "Usman", Score = 95 },
            new Student { Name = "Zain", Score = 75 }
        };

        // ----------------------------------------
        // 1. LINQ Query Syntax
        // ----------------------------------------
        var querySyntax =
            from s in students
            where s.Score > 70
            orderby s.Score descending
            select new
            {
                s.Name,
                s.Score
            };

        Console.WriteLine("Query Syntax Result:");
        foreach (var student in querySyntax)
        {
            Console.WriteLine($"{student.Name} - {student.Score}");
        }

        // ----------------------------------------
        // 2. Same query in Method Syntax
        // ----------------------------------------
        var methodSyntax = students
            .Where(s => s.Score > 70)          // Filter
            .OrderByDescending(s => s.Score)   // Sort
            .Select(s => new                   // Project
            {
                s.Name,
                s.Score
            });

        Console.WriteLine("\nMethod Syntax Result:");
        foreach (var student in methodSyntax)
        {
            Console.WriteLine($"{student.Name} - {student.Score}");
        }
    }
}

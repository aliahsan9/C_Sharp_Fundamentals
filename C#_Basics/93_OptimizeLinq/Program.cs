using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = GetStudents();

        // ✅ Filter FIRST
        // ✅ Select ONLY required columns
        var result = students
                     .Where(s => s.Marks > 80)
                     .Select(s => new
                     {
                         s.Name,
                         s.Marks
                     })
                     .ToList();   // Execute at the END

        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " " + item.Marks);
        }
    }

    static List<Student> GetStudents()
    {
        return new List<Student>
        {
            new Student { Id=1, Name="Ali", Marks=90 },
            new Student { Id=2, Name="Ahmad", Marks=60 },
            new Student { Id=3, Name="Imran", Marks=85 }
        };
    }
}
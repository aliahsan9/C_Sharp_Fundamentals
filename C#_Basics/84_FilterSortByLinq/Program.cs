using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Marks { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
             new Student {Id = 1, Name =  "Ali", Marks = 80},
             new Student {Id = 2, Name = "Ahmad", Marks = 90},
             new Student {Id = 3,  Name = "Saim", Marks = 100}
        };
        var result = students
            .Where(s => s.Marks > 80)   // Filter
            .OrderByDescending(s => s.Marks) // Sort
            .Select(s => new  // Projection
            {
                s.Name,
                s.Marks
            });
        // Print results after filtered , sorted and projecting students list
        Console.WriteLine("After Filtering, Sorting and Projecting Students:");
        foreach(var student in result)
        {
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }
    }
    
}
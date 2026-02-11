using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ali", Score = 85, Grade = "A" },
            new Student { Name = "Ahmed", Score = 72, Grade = "B" },
            new Student { Name = "Usman", Score = 90, Grade = "A" },
            new Student { Name = "Zain", Score = 65, Grade = "C" },
            new Student { Name = "Bilal", Score = 78, Grade = "B" }
        };

        // Group students by Grade using LINQ
        var groupedStudents = students
            .GroupBy(s => s.Grade); // Group by Grade property

        // Loop through each group
        foreach (var group in groupedStudents)
        {
            Console.WriteLine($"Grade: {group.Key}");

            // Loop through students in that grade
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Name} - {student.Score}");
            }

            Console.WriteLine(); // Blank line for readability
        }
    }
}

// Student class
class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
    public string Grade { get; set; }
}

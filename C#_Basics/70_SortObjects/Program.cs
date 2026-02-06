using System;
using System.Collections.Generic;

// Student class implementing IComparable
// This allows objects of Student to be sorted
class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Marks { get; set; }

    // Constructor
    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }

    // CompareTo method defines how objects will be compared
    // This method is automatically used by Sort()
    public int CompareTo(Student other)
    {
        // Safety check
        if (other == null)
            return 1;

        // Sorting logic:
        // Compare students based on Marks
        // Ascending order (smallest to largest)
        return this.Marks.CompareTo(other.Marks);

        // For descending order:
        // return other.Marks.CompareTo(this.Marks);
    }
}

class Program
{
    static void Main()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student("Ali", 75),
            new Student("Sara", 90),
            new Student("Ahmed", 60),
            new Student("Zara", 85)
        };

        // Sort the list
        // This automatically calls CompareTo()
        students.Sort();

        // Display sorted students
        Console.WriteLine("Students sorted by marks (ascending):");
        foreach (var student in students)
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
    }
}

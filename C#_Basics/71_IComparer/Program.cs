using System;
using System.Collections.Generic;

// Student class (no sorting logic here)
class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }

    // Constructor
    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }
}

// Custom comparer to sort by Marks
class MarksComparer : IComparer<Student>
{
    // Compare two students
    public int Compare(Student x, Student y)
    {
        // Safety checks
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;

        // Sort by Marks (ascending)
        return x.Marks.CompareTo(y.Marks);

        // For descending:
        // return y.Marks.CompareTo(x.Marks);
    }
}

// Custom comparer to sort by Name
class NameComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        // Safety checks
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;

        // Sort by Name alphabetically
        return x.Name.CompareTo(y.Name);
    }
}

class Program
{
    static void Main()
    {
        // Create list of students
        List<Student> students = new List<Student>
        {
            new Student("Ali", 75),
            new Student("Sara", 90),
            new Student("Ahmed", 60),
            new Student("Zara", 85)
        };

        // Sort by Marks using MarksComparer
        students.Sort(new MarksComparer());

        Console.WriteLine("Sorted by Marks:");
        foreach (var student in students)
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }

        Console.WriteLine();

        // Sort by Name using NameComparer
        students.Sort(new NameComparer());

        Console.WriteLine("Sorted by Name:");
        foreach (var student in students)
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
    }
}

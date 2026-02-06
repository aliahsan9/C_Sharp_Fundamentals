using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name;
    public int Marks;

    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }

    public int CompareTo(Student other)
    {
        if (other == null)
            return 1;

        return this.Marks.CompareTo(other.Marks);
    }
}

class Program
{
    static void Main(String[] args)
    {
        List<Student> students = new List<Student>
      {
        new Student ("Ali", 70),
        new Student ("Ahmad", 66),
        new Student ("Imran", 88)
       };

        students.Sort();

        Console.WriteLine("Students Sorted by marks:");

        foreach(var student in students)
        {
            Console.WriteLine($"{student.Name}, {student.Marks}");
        }
    }
}

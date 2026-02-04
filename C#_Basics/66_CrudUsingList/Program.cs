using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class StudentRepository
{
    // In-memory data, acts like a database
    private readonly List<Student> _students = new List<Student>();

    // Create Student
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    // Read All
    public List<Student> GetAllStudents()
    {
        return _students;
    }

    // Read By Id
    public Student GetStudentById(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }

    // Update Student
    public bool UpdateStudent(int id, string name, int age)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);

        if (student == null)
            return false;

        student.Name = name;
        student.Age = age;

        return true;
    }

    // Delete Student
    public bool DeleteStudent(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);

        if (student == null)
            return false;

        _students.Remove(student);
        return true;
    }
}

class Program
{
    static void Main()
    {
        var repository = new StudentRepository();

        repository.AddStudent(new Student { Id = 1, Name = "Ali", Age = 20 });
        repository.AddStudent(new Student { Id = 2, Name = "Ahmed", Age = 22 });

        Console.WriteLine("All Students:");
        foreach (var student in repository.GetAllStudents())
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
        }

        var singleStudent = repository.GetStudentById(1);
        if (singleStudent != null)
        {
            Console.WriteLine($"\nStudent Found: {singleStudent.Name}");
        }

        repository.UpdateStudent(1, "Ali Ahsan", 21);
        repository.DeleteStudent(2);

        Console.WriteLine("\nAfter Update & Delete:");
        foreach (var student in repository.GetAllStudents())
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
        }
    }
}

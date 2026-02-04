using System;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class StudentRepository
{
    private readonly Dictionary<int, Student> _students = new Dictionary<int, Student>();

    // Create Student
    public bool AddStudent(Student student)
    {
        if (_students.ContainsKey(student.Id))
            return false;

        _students.Add(student.Id, student);
        return true;
    }

    // Read All
    public List<Student> GetAllStudents()
    {
        return new List<Student>(_students.Values);
    }

    // Read By Id
    public Student GetStudentById(int id)
    {
        _students.TryGetValue(id, out var student);
        return student;
    }

    // Update Student
    public bool UpdateStudent(int id, string name, int age)
    {
        if (!_students.ContainsKey(id))
            return false;

        _students[id].Name = name;
        _students[id].Age = age;

        return true;
    }

    // Delete Student
    public bool DeleteStudent(int id)
    {
        return _students.Remove(id);
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

        var studentById = repository.GetStudentById(1);
        if (studentById != null)
        {
            Console.WriteLine($"\nStudent Found: {studentById.Name}");
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

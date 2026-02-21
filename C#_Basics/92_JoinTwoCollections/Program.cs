using System;
using System.Collections.Generic;
using System.Linq;

// Student Class (First Collection)
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; } // Foreign Key
}

// Department Class (Second Collection)
public class Department
{
    public int Id { get; set; }
    public string DeptName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // First Collection
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", DepartmentId = 1 },
            new Student { Id = 2, Name = "Ahmad", DepartmentId = 2 },
            new Student { Id = 3, Name = "Imran", DepartmentId = 3 } // No matching Dept
        };

        // Second Collection
        var departments = new List<Department>
        {
            new Department { Id = 1, DeptName = "Computer Science" },
            new Department { Id = 2, DeptName = "Information Technology" }
        };

        // INNER JOIN using LINQ Method Syntax
        var result = students.Join(

            departments,                       // Second Collection

            student => student.DepartmentId,  // FK from Students

            dept => dept.Id,                  // PK from Departments

            (student, dept) => new            // Combine both records
            {
                StudentName = student.Name,
                DepartmentName = dept.DeptName
            }

        );

        // Printing the Result
        Console.WriteLine("INNER JOIN Result:\n");

        foreach (var item in result)
        {
            Console.WriteLine(item.StudentName + " - " + item.DepartmentName);
        }
    }
}
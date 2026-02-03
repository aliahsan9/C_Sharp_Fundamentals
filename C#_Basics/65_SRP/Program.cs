using System;

class Student
{
    public string Name;
    public int Id;
    public string City;

    public Student(string name, int id, string city)
    {
        Name = name;
        Id = id;
        City = city;
    }
}
class PrintStudent
{
    public void Print(Student student)
    {
        Console.WriteLine($"Student's Name: {student.Name}, Id: {student.Id} and City: {student.City}");
    }
}
class StudentRepository
{
    public void Save(Student student)
    {
        Console.WriteLine("Student's data saved in Database");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Ali Ahsan", 101, "Lahore");

        PrintStudent p = new PrintStudent();
        StudentRepository r = new StudentRepository();

        p.Print(student);
        r.Save(student);
    }
}
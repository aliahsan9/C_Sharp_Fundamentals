using System;

class Student
{
    public string Name {get; set;}
    public int RollNumber {get; private set;}

    //public method for rollNumber
    public Student(int rollNumber)
    {
        RollNumber = rollNumber;
    }
}
class Program
{
static void Main(string[] args)
{
    Student s = new Student(10);
    s.Name = "Ali Ahsan";
    Console.WriteLine($"Name: {s.Name}, Roll Number: {s.RollNumber}");
}
}
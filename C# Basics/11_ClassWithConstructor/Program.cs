using System; // Importing the System namespace for input/output functionalities

// Class with Constructor and Additional Properties
class Student
{
    // Fields/Properties of the Student class
    public int studentID;     // To store the student ID
    public string name;       // To store the student's name
    public int age;           // To store the student's age
    public string course;     // To store the course the student is enrolled in

    // Constructor to initialize the student object with values
    public Student(int id, string studentName, int studentAge, string courseName)
    {
        studentID = id;          // Assigning student ID
        name = studentName;      // Assigning student name
        age = studentAge;        // Assigning age
        course = courseName;     // Assigning course
    }

    // Method to introduce the student
    public void Introduce()
    {
        // Printing student details to the console
        Console.WriteLine($"Student ID: {studentID}");
        Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and I'm enrolled in {course}.\n");
    }
}

class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Creating two Student objects using the constructor and assigning their data
        Student student1 = new Student(101, "Ali Ahsan", 20, "Computer Science");
        Student student2 = new Student(102, "John", 25, "Software Engineering");

        // Calling the Introduce method for each student object
        student1.Introduce();
        student2.Introduce();
    }
}

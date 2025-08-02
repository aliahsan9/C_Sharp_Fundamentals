using System;

//Class with Multiple Objects
class Student{
    public string name;
    public int age;

    public void introduce(){
        Console.WriteLine($"Hello, My name is {name} and I am {age} years Old.");
    }
}

class Program{
static void Main(string [] args){

    //Create Onjects Of Class Student
    Student Student1 = new Student();
    Student Student2 = new Student();

    //Assign Values to Object 1
    Student1.name = "Ali Ahsan";
    Student1.age = 20;

    Student2.name = "John";
    Student2.age = 25;

    //Call Method of Object 1

    Student1.introduce();
    Student2.introduce();
}
}
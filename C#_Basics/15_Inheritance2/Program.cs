using System;

class Student{
    public string firstName = "Ali";
    public string lastName = "Ahsan";


    public void Greeting(){
        Console.WriteLine("What'sUp");
    } 
}
 
class Student2 : Student{
    public int Age = 20;
}
class Program{

    static void Main(string[] args){
        Student myDetails = new Student();

        Student2 myDetails2 = new Student2();

        Console.WriteLine($"Hello, my name is {myDetails.firstName} {myDetails.lastName}, and I am {myDetails2.Age} years Old.");
        myDetails.Greeting();
    }
}
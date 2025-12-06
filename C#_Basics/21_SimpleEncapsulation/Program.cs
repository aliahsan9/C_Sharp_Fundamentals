using System;

class Person
{
    private string name;
    private int age;

    //public method to set name and age of person

    public void setPerson(string personName, int personAge)
    {
    if(personAge > 0)
    {
        name = personName;
        age = personAge;
    }
    }
    //Public function to display the person's name and age
    public void displayPerson()
    {
        Console.WriteLine($"Person's name is: {name} \nAge is: {age}.");
    }
}
class Program
{
public static void Main(string[] args)
{
    // making, an object for above class to get the properties, of above class using obj
    Person p1 = new Person();
    p1.setPerson("Ali Ahsan", 22);
    p1.displayPerson();
}
}
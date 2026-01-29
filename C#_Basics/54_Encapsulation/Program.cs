using System;

class Person
{
    // Private Fields
    private string name;
    private int age;

    // Public Property for Name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if(!String.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name si Not Valid!");
            }
        }
    }
    // Public Property for age
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value > 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("InValid Age!");
            }
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Display Function
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Program
{
    static void Main(String[] args)
    {
        Person person = new Person("Ali Ahsan", 22);

        person.DisplayInfo();
    }
}
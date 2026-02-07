using System;

// Generic class with type parameter T
public class Box<T>
{
    // Field of generic type
    private T _value;

    // Constructor to set value
    public Box(T value)
    {
        _value = value;
    }

    // Method to get value
    public T GetValue()
    {
        return _value;
    }

    // Method to set value
    public void SetValue(T value)
    {
        _value = value;
    }
}

class Program
{
    static void Main()
    {
        // Create Box for int
        Box<int> intBox = new Box<int>(10);
        Console.WriteLine("Int value: " + intBox.GetValue());

        // Create Box for string
        Box<string> stringBox = new Box<string>("Hello");
        Console.WriteLine("String value: " + stringBox.GetValue());

        // Change value
        stringBox.SetValue("World");
        Console.WriteLine("Updated string value: " + stringBox.GetValue());
    }
}

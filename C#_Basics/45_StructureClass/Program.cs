using System;

struct MyStruct
{
    public int Value;
}

class MyClass
{
    public int Value;
}

class Program
{
    static void Main()
    {
        // Struct behavior
        MyStruct s1 = new MyStruct();
        s1.Value = 10;
        MyStruct s2 = s1;   // copy
        s2.Value = 20;

        Console.WriteLine($"Struct s1: {s1.Value}");
        Console.WriteLine($"Struct s2: {s2.Value}");

        // Class behavior
        MyClass c1 = new MyClass();
        c1.Value = 10;
        MyClass c2 = c1;    // reference
        c2.Value = 20;

        Console.WriteLine($"Class c1: {c1.Value}");
        Console.WriteLine($"Class c2: {c2.Value}");
    }
}

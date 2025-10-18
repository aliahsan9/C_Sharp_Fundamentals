using System;

interface IShape
{
    void Draw();  //Abstract by default
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Circle is Drawing...");
    }
}
class Reactangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Reactangle is Drawing...");
    }
}
class Program
{
    static void Main(string[]args)
    {
        IShape circle = new Circle();
        circle.Draw();

        IShape rect = new Reactangle();
        rect.Draw();
    }
}
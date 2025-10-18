using System;

abstract class Shape
{
    public abstract void Draw();

    public void AreaOfShape()
    {
        Console.WriteLine("Claculating area of given shape...");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle...");
    }
}
class Reactangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a reactangle...");
    }
}
class Program
{
    static void Main()
    {
        Shape circle = new Circle();
        circle.AreaOfShape();
        circle.Draw();

        Shape rect = new Reactangle();
        rect.Draw();
    }
}
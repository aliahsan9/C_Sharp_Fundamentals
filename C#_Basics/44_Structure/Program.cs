using System;

struct Point
{
    public double X;
    public double Y;

    // Constructor
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Method to calculate distance to another point
    public double DistanceTo(Point other)
    {
        double dx = other.X - X;
        double dy = other.Y - Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(6, 7);

        double distance = p1.DistanceTo(p2);

        Console.WriteLine($"Distance between points: {distance}");
    }
}

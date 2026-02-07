public interface IVehicle
{
    void Start();
}

public abstract class Vehicle
{
    public abstract void Drive();

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}

public class Car : Vehicle, IVehicle
{
    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }

    public void Start()
    {
        Console.WriteLine("Car started.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Drive();
        car.Stop();
    }
}

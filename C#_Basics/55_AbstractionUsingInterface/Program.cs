using System;

interface IStudent
{
   void say();
}
class ClassRoom: IStudent
{
    public void say(){
        Console.WriteLine("Hello, how are you!");
}
}
class Program
{
    static void Main(String[] args)
    {
        IStudent obj = new ClassRoom();
        obj.say();
    }
}
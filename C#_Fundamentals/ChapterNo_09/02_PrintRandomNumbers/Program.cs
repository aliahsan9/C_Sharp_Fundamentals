using System;

class RandomNumbers
{
    private Random random = new Random();

    public int GenerateNumbers()
    {
        return random.Next(100, 201);
    }
    public void PrintRandomNumbers(int count)
    {
        for(int i = 0; i < count; i++)
        {
            Console.Write(GenerateNumbers()+ " ");
        }
    }
}
class Program
{
    public static void Main(String[] args)
    {
        RandomNumbers rng = new RandomNumbers();
        rng.PrintRandomNumbers(10);
    }
}
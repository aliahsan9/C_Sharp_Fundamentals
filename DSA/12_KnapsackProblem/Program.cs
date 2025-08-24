using System;

class Item
{
    public int Value;
    public int Weight;
    public Item(int v, int w)
    {
        Value = v;
        Weight = w;
    }
}

class Program
{
    static void Main()
    {
        Item[] items = {
            new Item(60, 10),
            new Item(100, 20),
            new Item(120, 30)
        };
        int capacity = 50;
        
        Array.Sort(items, (a, b) => (b.Value / (double)b.Weight).CompareTo(a.Value / (double)a.Weight));

        double totalValue = 0;
        foreach (var item in items)
        {
            if (capacity >= item.Weight)
            {
                capacity -= item.Weight;
                totalValue += item.Value;
            }
            else
            {
                totalValue += item.Value * ((double)capacity / item.Weight);
                break;
            }
        }
        Console.WriteLine("Maximum value in knapsack: " + totalValue);
    }
}

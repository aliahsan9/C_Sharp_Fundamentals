using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    { 
       int[] array = {1, 2, 3, 4, 4, 5, 6, 7, 2, 1, 2};

       Dictionary<int, int> countMap = new Dictionary<int, int>();

       foreach(int num in array)
       {
          if(countMap.ContainsKey(num))
          countMap[num]++;
          else 
          countMap[num] = 1;
       }
       //Display Result
       foreach(var item in countMap)
       {
        Console.WriteLine($"{item.Key} -> {item.Value} times");
       }
    }
}
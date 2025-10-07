using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] sequence = {1, 2, 3, 4 , 5, 6, 7, 7, 8, 8};

        Dictionary<int, int> countMap = new Dictionary<int, int>();

        foreach(int num in sequence) 
        {
            if(countMap.ContainsKey(num))
            countMap[num]++;
            else 
            countMap[num] = 1;
        }
        List<int> finalNums = new List<int>();

        foreach(int num in sequence)
        {
           if(countMap[num] % 2 == 0)
           {
           finalNums.Add(num);
           }
        }
        Console.WriteLine("Result Sequence is: {" + string.Join(", ", finalNums ) +  "}");
    }
}

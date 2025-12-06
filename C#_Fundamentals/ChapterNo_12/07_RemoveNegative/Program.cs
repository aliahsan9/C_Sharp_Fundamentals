using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegative
{
    public static void Main(String[] args)
    {
        int[] array = {1, 2, 3, -4, -5, 4, 5};
        for(int i = 0; i < array.Length; i++)
        {
              if(array[i] < 0)
                continue;
                Console.WriteLine(array[i]);
        }
    }
}
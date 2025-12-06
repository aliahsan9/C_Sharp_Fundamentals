using System;
using System.Collections.Generic;

class RecursionStackDemo
{
   static int Factorial(int n)
   {
      //Base Case
      if(n == 0)
      {
        return 1;
      }
      return n * Factorial(n - 1);
   }
   static void Main(String[] args)
   {
    Console.WriteLine("Factorial of 5 = " + Factorial(5));
   }
}
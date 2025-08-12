using System;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter a first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an operator:");
        int op = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int num2 = int.Parse(Console.ReadLine());
         
         switch (op)
         { 
            case:'1'
            if (op == +)
            {
                Console.WriteLine(num1 + num2);
            }
            break;
            case '2':
            if(op == -)
            {
                Console.WriteLine(num1 - num2);
            }
            break;
            case '3':
            if(op == /)
            {
                Console.WriteLine(num1 / num2);
            }
            break;
            case '4':
            if(op == %){
            Console.WriteLine(num1 % num2);
            }
            break;
            case '5':
            if( op == *)
            {
                Console.WriteLine(num1 * num2);
            }
            default:
            Console.WriteLine("Invalid Operator!");
         }
     
    }
}
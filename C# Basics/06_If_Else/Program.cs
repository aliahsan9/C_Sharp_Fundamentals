using System;

class Program {
    static void Main(string[] args){

        Console.WriteLine("Enter a Number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num > 0){
            Console.WriteLine("The Number is Positive");
        }else{
            Console.WriteLine("The Number is Negative");
        }

        if(num % 2 == 0){
            Console.WriteLine("The Number is Even");
        }else{
            Console.WriteLine("The Number is Odd");
        }

      
        Console.WriteLine("Enter a Number between 1 and 7:");
        int day = Convert.ToInt32(Console.ReadLine());

      switch(day){ 
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday");
        break;

        case 3:             
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;

        case 5:
        Console.WriteLine("Friday");
        break;

        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;

        default:
        Console.WriteLine("Invalid Day");
        break;
      }

      Console.WriteLine("Day: "+ day);

    }
}
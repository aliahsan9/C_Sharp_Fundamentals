using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter an Operator:");
        string op = Console.ReadLine();

        Console.WriteLine("Enter a Second Number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        bool isValid = true;

        switch (op) {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0) {
                    result = num1 / num2;
                } else {
                    Console.WriteLine("Cannot Divide by Zero!");
                    isValid = false;
                }
                break;
            case "%":
                if (num2 != 0) {
                    result = num1 % num2;
                } else {
                    Console.WriteLine("Cannot Divide by Zero!");
                    isValid = false;
                }
                break;
            default:
                Console.WriteLine("Invalid Operator!");
                isValid = false;
                break;
        }

        if (isValid) {
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }
    }
}

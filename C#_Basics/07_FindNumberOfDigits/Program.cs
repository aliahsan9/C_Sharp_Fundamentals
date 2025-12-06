using System;

class Program{
    static void Main(string [] args){
        Console.WriteLine("Enter any Integers:");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0; 
        int temp = Math.Abs(num);

        if(temp == 0){
            // If the number is 0, it has exactly one digit.
            count = 1;

        } else {
            // For non-zero numbers, we count the digits by repeatedly dividing by 10.
            // Example: If the number is 1234
            // Step 1: temp = 1234, count = 0
            // Step 2: temp = 1234 / 10 = 123, count = 1
            // Step 3: temp = 123 / 10 = 12, count = 2
            // Step 4: temp = 12 / 10 = 1, count = 3
            // Step 5: temp = 1 / 10 = 0, count = 4 (loop ends)
            while (temp > 0) {
                temp == temp / 10; // Remove the last digit of the number.
                count++; // Increment the digit count.
            }
        }
        Console.WriteLine("Total Integers are: "+ count);
    }
}
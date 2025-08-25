static void Menu()
{
    while (true)
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Reverse digits of number");
        Console.WriteLine("2. Average of sequence");
        Console.WriteLine("3. Solve linear equation (a*x + b = 0)");
        Console.WriteLine("4. Exit");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter number (1..50,000,000): ");
                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 50000000) { Console.WriteLine("Invalid input!"); break; }
                PrintReversedDigits(n);
                break;

            case "2":
                Console.Write("Enter numbers separated by space: ");
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (nums.Length == 0) { Console.WriteLine("Sequence cannot be empty."); break; }
                Console.WriteLine($"Average = {(double)nums.Sum() / nums.Length}");
                break;

            case "3":
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                if (a == 0) { Console.WriteLine("a must be non-zero."); break; }
                Console.WriteLine($"Solution: x = {-b / a}");
                break;

            case "4":
                return;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}

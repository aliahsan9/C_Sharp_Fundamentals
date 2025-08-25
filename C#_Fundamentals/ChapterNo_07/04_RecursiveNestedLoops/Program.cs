using System;

class RecursiveNestedLoops
{
    // Number of nested loops we want to generate
    static int numberOfLoops;

    // Number of iterations each loop will go through
    static int numberOfIterations;

    // Array to hold the current values of all loops
    static int[] loops;

    static void Main()
    {
        // Ask user for the number of loops (N)
        Console.Write("N = ");
        numberOfLoops = int.Parse(Console.ReadLine());

        // Ask user for the number of iterations per loop (K)
        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        // Initialize the array to store loop values
        loops = new int[numberOfLoops];

        // Start recursion from the first loop (index 0)
        NestedLoops(0);
    }

    // Recursive method to generate all possible combinations of loops
    static void NestedLoops(int currentLoop)
    {
        // Base case: If we have filled all loops, print the result
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        // Recursive case: Try all values for the current loop
        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            // Assign the current counter value to the loop at current index
            loops[currentLoop] = counter;

            // Recurse to fill the next loop
            NestedLoops(currentLoop + 1);
        }
    }

    // Prints the current combination of loops
    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine(); // Move to next line after printing one combination
    }
}

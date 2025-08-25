using System;

class IterativeNestedLoops
{
    // Number of nested loops we want to simulate
    static int numberOfLoops;

    // Number of iterations each loop should perform
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

        // Initialize the loops array with starting values
        loops = new int[numberOfLoops];

        // Generate and print all loop combinations using iteration
        NestedLoops();
    }

    // Iterative method to generate combinations
    static void NestedLoops()
    {
        // First, set all loop counters to 1
        InitLoops();

        int currentPosition; // Tracks which loop index we are modifying

        // Infinite loop - we break/return when all combinations are exhausted
        while (true)
        {
            // Print the current loop combination
            PrintLoops();

            // Start incrementing from the last loop (like simulating nested loops)
            currentPosition = numberOfLoops - 1;
            loops[currentPosition]++;

            // Carry over logic: when a loop exceeds max iterations, reset it and move left
            while (loops[currentPosition] > numberOfIterations)
            {
                // Reset current loop back to 1
                loops[currentPosition] = 1;

                // Move one loop back
                currentPosition--;

                // If we've gone past the first loop, all combinations are done
                if (currentPosition < 0)
                {
                    return;
                }

                // Increment the next loop to the left
                loops[currentPosition]++;
            }
        }
    }

    // Initialize all loop values to 1
    static void InitLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            loops[i] = 1;
        }
    }

    // Prints the current combination of loop values
    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}

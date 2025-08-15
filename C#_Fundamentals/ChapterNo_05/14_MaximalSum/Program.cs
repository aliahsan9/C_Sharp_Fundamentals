using System;

class Program
{
    static void Main()
    {
        // Step 1: Read N and K
        Console.Write("Enter N (array size): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter K (number of consecutive elements, K < N): ");
        int K = int.Parse(Console.ReadLine());

        if (K >= N)
        {
            Console.WriteLine("K must be less than N.");
            return;
        }

        // Step 2: Read array elements
        int[] arr = new int[N];
        Console.WriteLine($"Enter {N} integers (space separated):");
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        // Step 3: Sliding Window Technique
        int currentSum = 0;
        for (int i = 0; i < K; i++)
        {
            currentSum += arr[i];
        }
 
        int maxSum = currentSum;
        int startIndex = 0;

        for (int i = K; i < N; i++)
        {
            currentSum += arr[i] - arr[i - K]; // Slide window
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = i - K + 1;
            }
        }

        // Step 4: Output result
        Console.WriteLine($"Max Sum: {maxSum}");
        Console.Write("Elements: ");
        for (int i = startIndex; i < startIndex + K; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;

class MazeSolver
{
    static int[,] maze =
    {
        { 1, 0, 1, 1 },
        { 1, 1, 1, 0 },
        { 0, 1, 0, 1 },
        { 1, 1, 1, 1 }
    };

    static int n = 4;

    // Directions: down, right, up, left
    static int[] dx = { 1, 0, -1, 0 };
    static int[] dy = { 0, 1, 0, -1 };

    public static bool SolveMaze()
    {
        Stack<(int x, int y)> stack = new Stack<(int, int)>();
        bool[,] visited = new bool[n, n];

        stack.Push((0, 0));
        visited[0, 0] = true;

        while (stack.Count > 0)
        {
            var (x, y) = stack.Peek();

            // If goal is reached
            if (x == n - 1 && y == n - 1)
            {
                Console.WriteLine("Path found:");
                foreach (var step in stack)
                    Console.WriteLine(step);
                return true;
            }

            bool moved = false;

            // Try all 4 directions
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (IsValid(nx, ny, visited))
                {
                    stack.Push((nx, ny));
                    visited[nx, ny] = true;
                    moved = true;
                    break;
                }
            }

            // If no move possible → backtrack (pop)
            if (!moved)
            {
                stack.Pop();
            }
        }

        return false;
    }

    static bool IsValid(int x, int y, bool[,] visited)
    {
        return x >= 0 && x < n && y >= 0 && y < n 
            && maze[x, y] == 1 
            && !visited[x, y];
    }

    static void Main()
    {
        if (!SolveMaze())
            Console.WriteLine("No path found!");
    }
}

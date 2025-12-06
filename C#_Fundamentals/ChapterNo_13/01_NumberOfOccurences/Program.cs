using System;
using System.Collections.Generic;

class TreeNode
{
    public int Value;       // Stores the value of the node
    public TreeNode Left;   // Pointer to the left child
    public TreeNode Right;  // Pointer to the right child

    public TreeNode(int value)
    {
        Value = value;      // Assign value to the node
        Left = null;        // Initially, left child is null
        Right = null;       // Initially, right child is null
    } 
}

class BinaryTree
{
    public TreeNode Root;   // Root node of the binary tree

    public BinaryTree()
    {
        Root = null;        // Start with an empty tree
    }

    // Iterative BFS method to count occurrences of a target number
    public int CountOccurrencesBFS(TreeNode root, int target)
    {
        if (root == null)   // If tree is empty, return 0
            return 0;

        int count = 0;  // To store the number of occurrences
        Queue<TreeNode> queue = new Queue<TreeNode>(); // Queue for BFS
        queue.Enqueue(root); // Start by adding the root to the queue

        // While queue has nodes, keep processing
        while (queue.Count > 0)
        {
            // Remove (dequeue) the first node in the queue
            TreeNode current = queue.Dequeue();

            // If current node's value matches the target, increment count
            if (current.Value == target)
                count++;

            // If left child exists, add it to the queue
            if (current.Left != null)
                queue.Enqueue(current.Left);

            // If right child exists, add it to the queue
            if (current.Right != null)
                queue.Enqueue(current.Right);
        }

        // After visiting all nodes, return the total count
        return count;
    }
}

class Program
{
    static void Main()
    {
        // Build a sample binary tree manually
        // Tree structure:
        //        5
        //       / \
        //      3   5
        //     / \    \
        //    5   2    5

        BinaryTree tree = new BinaryTree();
        tree.Root = new TreeNode(5);
        tree.Root.Left = new TreeNode(3);
        tree.Root.Right = new TreeNode(5);
        tree.Root.Left.Left = new TreeNode(5);
        tree.Root.Left.Right = new TreeNode(2);
        tree.Root.Right.Right = new TreeNode(5);

        // Ask user for a number to search
        Console.Write("Enter the number to count: ");
        int target = int.Parse(Console.ReadLine());

        // Call BFS counting method
        int occurrences = tree.CountOccurrencesBFS(tree.Root, target);

        // Print result
        Console.WriteLine($"Number {target} occurs {occurrences} times in the tree.");
    }
}

using System;

class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

class BinaryTree
{
    Node root;

    // Recursive function to count nodes in subtrees
    int CountNodes(Node node, int k)
    {
        if (node == null)
            return 0;

        // Count nodes in left and right subtrees
        int leftCount = CountNodes(node.left, k);
        int rightCount = CountNodes(node.right, k);

        int totalNodes = leftCount + rightCount + 1;

        // If subtree rooted at this node has exactly k nodes
        if (totalNodes == k)
            Console.WriteLine("Subtree with " + k + " nodes has root: " + node.data);

        return totalNodes;
    }

    public void DisplaySubtreeRootsWithKNodes(int k)
    {
        Console.WriteLine("\nSubtrees having exactly " + k + " nodes:");
        CountNodes(root, k);
    }

    // Example tree creation
    public void CreateTree()
    {
        root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        root.right.left = new Node(6);
        root.right.right = new Node(7);
    }

    static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.CreateTree();

        Console.Write("Enter value of k: ");
        int k = int.Parse(Console.ReadLine());

        tree.DisplaySubtreeRootsWithKNodes(k);
    }
}

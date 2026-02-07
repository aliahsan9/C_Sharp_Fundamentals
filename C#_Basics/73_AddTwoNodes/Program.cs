using System;

class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode AddTwoNodes(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null)
                l1 = l1.next;

            if (l2 != null)
                l2 = l2.next;
        }

        return dummyHead.next;
    }
}

class Program
{
    // Helper method to create linked list from array
    static Solution.ListNode CreateList(int[] arr)
    {
        Solution.ListNode dummy = new Solution.ListNode(0);
        Solution.ListNode current = dummy;

        foreach (int num in arr)
        {
            current.next = new Solution.ListNode(num);
            current = current.next;
        }

        return dummy.next;
    }

    // Helper method to print linked list
    static void PrintList(Solution.ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " ");
            node = node.next;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] arr1 = { 2, 4, 3 };
        int[] arr2 = { 5, 6, 4 };

        Solution s = new Solution();

        var l1 = CreateList(arr1);
        var l2 = CreateList(arr2);

        Solution.ListNode result = s.AddTwoNodes(l1, l2);

        Console.Write("Sum of Two Linked Lists: ");
        PrintList(result);
    }
}

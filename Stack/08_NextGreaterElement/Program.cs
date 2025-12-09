using System;
using System.Collections.Generic;

public class Solution
{
    public int[] NextGreaterElement(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> st = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            // Remove all elements that are <= current element
            while (st.Count > 0 && st.Peek() <= nums[i])
                st.Pop();

            // If stack is empty → no greater element exists
            result[i] = st.Count == 0 ? -1 : st.Peek();

            // Push current element
            st.Push(nums[i]);
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] nums = { 4, 5, 2, 25, 7, 8 };
        int[] ans = sol.NextGreaterElement(nums);

        Console.WriteLine("Next Greater Elements:");
        foreach (var x in ans)
        {
            Console.Write(x + " ");
        }
    }
}

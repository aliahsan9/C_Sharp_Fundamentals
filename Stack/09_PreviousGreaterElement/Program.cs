using System;
using System.Collections.Generic;

class Solution
{
    public int[] PreviousGreaterElement(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        Stack<int> st = new Stack<int>();

        for (int i = 0; i < n; i++)  // <-- FIXED CONDITION
        {
            // Remove smaller or equal elements
            while (st.Count > 0 && st.Peek() <= nums[i])
            {
                st.Pop();
            }

            // If empty → no previous greater element
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
        int[] nums = { 2, 4, 8, 12, 25, 6 };
        int[] ans = sol.PreviousGreaterElement(nums);

        Console.WriteLine("Previous Greater Elements are:");
        foreach (var x in ans)
        {
            Console.Write(x + " ");
        }
    }
}

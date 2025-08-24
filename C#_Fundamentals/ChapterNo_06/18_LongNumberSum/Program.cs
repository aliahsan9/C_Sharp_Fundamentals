using System;

class Program
{
    static List<int> SumBigIntegers(int[] num1, int[] num2)
{
    List<int> result = new List<int>();
    int carry = 0, maxLen = Math.Max(num1.Length, num2.Length);

    for (int i = 0; i < maxLen; i++)
    {
        int digit1 = i < num1.Length ? num1[i] : 0;
        int digit2 = i < num2.Length ? num2[i] : 0;
        int sum = digit1 + digit2 + carry;

        result.Add(sum % 10);
        carry = sum / 10;
    }

    if (carry > 0)
        result.Add(carry);

    return result; // digits in reversed order
}
    static void Main()
    {
    
}
}
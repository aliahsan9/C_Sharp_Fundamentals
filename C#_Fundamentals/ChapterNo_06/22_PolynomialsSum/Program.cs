static int[] SumPolynomials(int[] p1, int[] p2)
{
    int maxLen = Math.Max(p1.Length, p2.Length);
    int[] result = new int[maxLen];

    for (int i = 0; i < maxLen; i++)
    {
        int coef1 = i < p1.Length ? p1[i] : 0;
        int coef2 = i < p2.Length ? p2[i] : 0;
        result[i] = coef1 + coef2;
    }
    return result;
}

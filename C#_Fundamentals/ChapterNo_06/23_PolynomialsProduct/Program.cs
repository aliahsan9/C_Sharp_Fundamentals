static int[] MultiplyPolynomials(int[] p1, int[] p2)
{
    int[] result = new int[p1.Length + p2.Length - 1];

    for (int i = 0; i < p1.Length; i++)
    {
        for (int j = 0; j < p2.Length; j++)
        {
            result[i + j] += p1[i] * p2[j];
        }
    }
    return result;
}

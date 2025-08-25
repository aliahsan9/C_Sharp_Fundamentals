static int FindMaxIndex(int[] arr, int start)
{
    int maxIndex = start;
    for (int i = start + 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxIndex])
            maxIndex = i;
    }
    return maxIndex;
}

static void SortDescending(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxIndex = FindMaxIndex(arr, i);
        int temp = arr[i];
        arr[i] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
}

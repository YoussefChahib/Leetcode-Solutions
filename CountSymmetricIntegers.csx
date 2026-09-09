public int CountSymmetricIntegers(int low, int high)
{
    if (low == high) return 1;
    int count = 0;
    for (int i = low; i < high + 1; i++)
    {
        string current = i.ToString();
        if (current.Length % 2 != 0) continue;
        int leftP = 0;
        int rightP = current.Length - 1;
        int r = 0;
        int l = 0;
        while (leftP < rightP)
        {
            l += (int)current[leftP];
            r += (int)current[rightP];
            leftP++; rightP--;
        }
        if (r == l) count++;
    }
    return count;
}


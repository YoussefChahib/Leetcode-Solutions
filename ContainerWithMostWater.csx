public int MaxArea(int[] height)
{
    int max = 0;
    for (int i = 0; i < (int)(height.Length / 2); i++)
    {
        for (int j = i; j < (height.Length / 2); j++)
        {
            int current = Math.Min(height[i], height[j]) * (j - i);
            if (current > max) max = current;
        }
        for (int j = (height.Length / 2); j < height.Length; j++)
        {
            int current = Math.Min(height[i], height[j]) * (j - i);
            if (current > max) max = current;
        }
    }

    for (int i = (height.Length / 2); i < height.Length; i++)
    {
        for (int j = i; j < height.Length; j++)
        {
            int current = Math.Min(height[i], height[j]) * (j - i);
            if (current > max) max = current;
        }
        for (int j = (height.Length / 2); j < height.Length; j++)
        {
            int current = Math.Min(height[i], height[j]) * (j - i);
            if (current > max) max = current;
        }
    }

    return max;
}

public int MaxArea(int[] height)
{
    int leftP = 0;
    int rightP = height.Length - 1;
    int max = 0;
    while (rightP > leftP)
    {
        int current = Math.Min(height[rightP], height[leftP]) * (rightP - leftP);
        if (current > max) max = current;
        bool rightSmaller = height[rightP] - height[leftP] < 0;
        if (rightSmaller) rightP--; else leftP++;
    }
    return max;
}


Console.WriteLine(MaxArea2([1, 8, 6, 2, 5, 4, 8, 3, 7]));
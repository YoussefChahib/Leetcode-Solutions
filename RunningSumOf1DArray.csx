public int[] RunningSum(int[] nums)
{
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        int item = 0;
        for (int j = i; j >= 0; j--)
        {
            item += nums[j];
        }
        result[i] = item;
    }
    return result;
}

public int[] RunningSum2(int[] nums)
{
    int[] result = new int[nums.Length];
    int current = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        current += nums[i];
        result[i] = current;
    }
    return result;
}
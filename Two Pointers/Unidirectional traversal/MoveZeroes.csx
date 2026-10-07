public void MoveZeroes(int[] nums)
{
    int nonZeroP = 0;
    int zeroP = 0;
    while (zeroP < nums.Length && nonZeroP < nums.Length)
    {
        if (nums[zeroP] == 0 && nums[nonZeroP] != 0)
        {
            if (zeroP < nonZeroP)
            {
                int temp = nums[nonZeroP];
                nums[nonZeroP] = 0;
                nums[zeroP] = temp;
            }
            else nonZeroP++;
        }

        if (nums[zeroP] != 0) zeroP++;
        if (nums[nonZeroP] == 0) nonZeroP++;
    }
    Console.WriteLine($"[{string.Join(", ", nums)}]");
}

public int[] MoveZeroes2(int[] nums)
{
    int[] result = new int[nums.Length];
    int zeroesCounter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0) zeroesCounter++;
    }
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (zeroesCounter == 0) { result = nums; break; }
        if (nums[i] != 0) { result[j] = nums[i]; j++; }
    }
    Console.WriteLine($"[{string.Join(", ", result)}]");
    return result;
}
MoveZeroes2([1, 4, 3, 0, 0, 2, 0]);
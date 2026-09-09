public int MinLengthAfterRemovals(IList<int> nums)
{
    int len = nums.Count;
    if (len == 0) return 0;
    if (len == 1) return 1;

    int result = 0;
    int leftPointer = 0;
    int rightPointer = (len - 1) / 2;

    while (leftPointer < (len / 2) && rightPointer < len)
    {
        if (nums[leftPointer] < nums[rightPointer])
        {
            leftPointer++; rightPointer++; result++;
        }
        else
        {
            rightPointer++;
        }
    }

    return len - result * 2;
}

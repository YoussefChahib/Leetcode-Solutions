public void NextPermutation(int[] nums)
{
    int len = nums.Length;
    if (len < 2) return;

    int p1 = len - 2;
    while (p1 >= 0 && nums[p1] >= nums[p1 + 1]) p1--;

    if (p1 == -1)
    {
        Array.Reverse(nums);
        return;
    }

    int p2 = len - 1;
    while (nums[p2] <= nums[p1]) p2--;

    (nums[p2], nums[p1]) = (nums[p1], nums[p2]);
    Array.Reverse(nums, p1 + 1, len - 1 - p1);
}
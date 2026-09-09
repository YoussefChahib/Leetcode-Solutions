public bool IsPalindrome(int x)
{
    if (x < 0) return false;
    string sx = x.ToString();
    int leftP = 0;
    int rightP = sx.Length - 1;
    while (leftP < rightP)
    {
        if (sx[leftP] != sx[rightP]) return false;
        leftP++; rightP--;
    }
    return true;
}

public bool IsPalindrome2(int x)
{
    if (x < 0) return false;
    int reversed = 0;
    int original = x;
    while (original > 0)
    {
        int d = original % 10;
        reversed = reversed * 10 + d;
        original /= 10;
    }
    if (reversed == x) return true;
    return false;
}

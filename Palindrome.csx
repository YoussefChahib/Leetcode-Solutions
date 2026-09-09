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
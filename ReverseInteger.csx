public long Reverse(long x)
{
    bool isNegatif = x < 0;
    long temp = isNegatif ? x = Math.Abs(x) : x;
    long reversed = 0;
    while (temp > 0)
    {
        reversed = reversed * 10 + temp % 10;
        temp /= 10;
    }
    return isNegatif ? -1 * reversed : reversed;
}

public int Reverse2(long x)
{
    bool isNegatif = x < 0;
    long temp = Math.Abs(x);
    long reversed = 0;
    while (temp > 0)
    {
        reversed = reversed * 10 + temp % 10;
        temp /= 10;
    }
    return isNegatif ? (-reversed < (long)int.MinValue ? 0 : -(int)reversed)
        : (reversed > int.MaxValue ? 0 : (int)reversed);
}

public int Reverse3(long x)
{
    bool isNegatif = x < 0;
    string s = Math.Abs(x).ToString();
    string result = "";
    for (int i = s.Length - 1; i > -1; i--)
    {
        result += s[i];
    }
    long reversed = long.Parse(result);
    bool outBound = reversed > int.MaxValue;
    return isNegatif ? outBound ? 0 : -(int)reversed : outBound ? 0 : (int)reversed;
}

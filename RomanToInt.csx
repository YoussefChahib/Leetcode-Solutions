public int RomanToInt(string s)
{
    Dictionary<int, string> Symbol = new Dictionary<int, string> {
        { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 90, "XC" },
        { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" }
    };
    int result = 0;
    foreach (var i in Symbol)
    {
        while (s.StartsWith(i.Value) && !string.IsNullOrEmpty(s))
        {
            result += i.Key;
            s = s.Remove(0, i.Value.Length);
        }

    }
    return result;
}
public int RomanToInt2(string s)
{
    int result = 0;
    Dictionary<string, int> Symbol = new Dictionary<string, int> {
        { "M", 1000 }, { "CM", 900 }, { "D", 500 },{ "CD", 400 }, { "C", 100 }, { "XC", 90 },
        { "L", 50 }, { "XL", 40 }, { "X", 10 }, {"IX", 9 }, { "V", 5 }, { "IV", 4 }, { "I", 1 }
    };
    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1 && Symbol[s[i].ToString()] < Symbol[s[i + 1].ToString()])
        {
            result += Symbol[s.Substring(i, 2)];
            i += 1;
        }
        else
        {
            result += Symbol[s[i].ToString()];
        }
        if (i == s.Length - 1) break;
    }
    return result;
}

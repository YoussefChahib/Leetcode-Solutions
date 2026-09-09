public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        int len = s.Length;
        if (len == 0) return 0;
        else if (len == 1) return 1;
        else
        {
            int[] asciList = new int[1000];
            int result = 0;
            for (int i = 0; i < len; i++)
            {
                int currentTotal = 0;
                for (int j = i; j < len; j++)
                {
                    if (asciList[s[j]] > 0)
                    {
                        asciList = new int[1000];
                        break;
                    }
                    asciList[s[j]]++;
                    currentTotal++;
                }
                if (currentTotal > result) result = currentTotal;
            }
            return result;
        }
    }
}
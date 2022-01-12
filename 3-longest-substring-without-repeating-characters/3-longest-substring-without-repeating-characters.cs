public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var charSet = new HashSet<char>();
        int l = 0;
        int res = 0;
        for (int r = 0; r < s.Length; r++)
        {
            while (charSet.Contains(s[r]))
            {
                charSet.Remove(s[l]);
                l += 1;
            }
            charSet.Add(s[r]);
            if (res < r - l + 1)
                res = r - l + 1;
        }

        return res;
    }
}
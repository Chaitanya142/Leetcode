public class Solution
{
    public string LongestPalindrome(string s)
    {
        int strLen = s.Length;
        string res = "";
        int resLen = 0;
        if (s.Length == 1)
        {
            return s;
        }
        for (int len = 0; len < strLen; len++)
        {
            //Odd Length
            //if(len%2==1){
            int l = len;
            int r = len;
            while (l >= 0 && r < strLen && s[l] == s[r])
            {
                if ((r - l + 1) > resLen)
                {
                    res = s.Substring(l, r - l + 1);
                    resLen = r - l + 1;
                }
                l -= 1;
                r += 1;
            }

            //}
            //Even Length
            //else{
            //int l=len;
            //int r=len+1;
            l = len;
            r = len + 1;
            while (l >= 0 && r < strLen && s[l] == s[r])
            {
                if ((r - l + 1) > resLen)
                {
                    res = s.Substring(l, r - l + 1);
                    resLen = r - l + 1;
                }
                l -= 1;
                r += 1;
                //  }

            }
        }
        Console.WriteLine(resLen);
        return res;
    }
}
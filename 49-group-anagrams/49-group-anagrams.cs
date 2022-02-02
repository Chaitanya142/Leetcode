public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        IList<IList<string>> lst = new List<IList<string>>();

        var distinctStrs = strs;//.Distinct();

        if (distinctStrs.Count() == 0)
        {
            return new List<IList<string>>() { new List<string>() { "" } };
        }

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach (string str in distinctStrs)
        {
            var chars = getChars(str);
            if (!dict.ContainsKey(chars)) dict.Add(chars, new List<string>());
            dict[chars].Add(str);
        }

        foreach (var v in dict.Values.ToList())
        {
            lst.Add(v);
        }
        return lst;
    }

    public string getChars(string s)
    {

        /*
        int[] arr = new int[26];
        int aChar = (int)'a';

        foreach (char c in s)
        {
            arr[(int)c - aChar]++;
        }
        return string.Join(",", arr);
        */
        var chars = s.ToArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
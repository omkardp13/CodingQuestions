public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        if (s.Length > t.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
            }
            else
            {
                dict.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (dict.ContainsKey(t[i]))
            {
                if (dict[t[i]] != 0)
                    dict[t[i]]--;
                else
                    return false;
            }
            else
            {
                return false;

            }
        }

        foreach (var item in dict)
        {
            if (item.Value > 1)
            { return false; }
        }

        return true;
    }
}
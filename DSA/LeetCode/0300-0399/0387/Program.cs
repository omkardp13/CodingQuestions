public class Solution
{
    public int FirstUniqChar(string s)
    {
        int[] arr = new int[26];
        foreach (char c in s)
        {
            arr[c - 'a']++;
        }

        int n = s.Length;
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (arr[ch - 'a'] == 1)
                return i;
        }
        return -1;
    }
}
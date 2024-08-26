using System;
using System.Linq;
using System.Net.Http.Headers;

public class Solution
{

    public static string LongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);
        int index = 0;
        string str1 = strs[0];
        string str2 = strs[strs.Length-1];

        for (int i=0;i<str1.Length;i++)
        {
            if (str1[i] == str2[i])
                index++;
            else
                break;
        }

        return index == 0 ? "" :str1.Substring(0, index) ;
    }
}
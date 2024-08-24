using System;

public class Solution
{

    public static int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' ');
        int counter = words.Length - 1;
        while (counter>=0)
        {
            if (words[counter]!=string.Empty)
            {
                return words[counter].Length;
            }
            counter--;
        }

        return -1;
    }
}
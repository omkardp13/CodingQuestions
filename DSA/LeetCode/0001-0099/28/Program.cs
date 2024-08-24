public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
            return -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (CompareStrings(i, haystack, needle))
                {
                    return i;
                }
            }
        }

        return -1;
    }

    public bool CompareStrings(int index, string haystack, string needle)
    {
        int counter = 0;



        if ((index + needle.Length) > haystack.Length)
            return false;

        for (int i = index; i < index + (needle.Length); i++)
        {
            if (haystack[i] != needle[counter])
            {
                return false;
            }
            counter++;
        }
        return true;
    }
}
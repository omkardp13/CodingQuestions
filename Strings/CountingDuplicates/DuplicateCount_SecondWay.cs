using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    /*
     * 
     * Time Complexity: O(n)

       Space Complexity: O(n)
     * 
 
     */
    public static int DuplicateCount(string str)
    {
        
        int count = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        str=str.ToLower();

        for (int i = 0; i < str.Length; i++)
        {
            if (!dict.ContainsKey(str[i]))
            {
                dict.Add(str[i], 1);
            }
            else
            {
                dict[str[i]]++;
            }
        }

        foreach (var keyValue in dict)
        {
            if (keyValue.Value > 1)
                count++;
        }
        return count;
    }
    static void Main()
    {

        string str = "aabBcde";

        Console.WriteLine(DuplicateCount(str));
        Console.ReadLine();
    }

   
}

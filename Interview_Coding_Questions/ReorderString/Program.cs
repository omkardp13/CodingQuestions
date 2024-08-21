using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string order = "bca";
        string str = "abc";

        
        Dictionary<char, char> charDict = new Dictionary<char, char>();

        foreach (char c in str)
        {
            if (!charDict.ContainsKey(c))
            {
                charDict[c] = c;
            }
        }

        StringBuilder sb = new StringBuilder();

       
        foreach (char c in order)
        {
            if (charDict.ContainsKey(c))
            {
                sb.Append(charDict[c]);
            }
        }

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}

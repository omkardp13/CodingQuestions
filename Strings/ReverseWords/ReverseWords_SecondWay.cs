using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public static string ReverseWords(string str)
    {
        string[] strings = str.Split(' ');

        for (int i = 0; i < strings.Length; i++)
        {
            char[] chars = strings[i].ToCharArray();

            for (int j = 0; j < chars.Length / 2; j++)
            {
                char c = chars[j];
                chars[j] = chars[chars.Length - 1 - j];
                chars[chars.Length - 1 - j] = c;
            }

            strings[i] = new string(chars);
        }

        return string.Join(" ", strings); 
    }


    public static void Main()
    {
        string str = "This is an example!";
        Console.WriteLine(ReverseWords(str));
        Console.ReadLine();
    }
}

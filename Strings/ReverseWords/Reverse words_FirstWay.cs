using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Select(x =>new string(x.Reverse().ToArray())));
    }

    public static void Main()
    {
        string str = "This is an example!";
        Console.WriteLine(ReverseWords(str));
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{

    public static string FirstNonRepeatingLetter(string s)
    {

        var result=s.GroupBy(c=>Char.ToLower(c)).FirstOrDefault(group=>group.Count()==1);

        if (result == null)
              return string.Empty;
        // Return the first non-repeating character in its original case
        return s.First(c=>char.ToLower(c)==result.Key).ToString();
    }

    public static void Main()
    {
        string str = "stress";
        Console.WriteLine(FirstNonRepeatingLetter(str));



        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{

    public static string Order(string words)
    {
       
        var result=words.Split(' ').OrderBy(word=>word.FirstOrDefault(Char.IsDigit)).ToArray();

        return string.Join(" ", result);
    }


    public static void Main()
    {
        string str = "is2 Thi1s T4est 3a";
        Console.WriteLine(Order(str));



        Console.ReadLine();
    }
}

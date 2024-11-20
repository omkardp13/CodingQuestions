using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{

    public static bool XO(string input)
    {
        input = input.ToLower();
        int xCount=input.Count(x => x=='x');

        int oCount = input.Count(x => x == 'o');

        if(xCount==oCount)
        {
            return true;
        }

        return false;
  }


    public static void Main()
    {
        string str = "ooxx";

        if(XO(str))
        {
            Console.WriteLine("Balanced");
        }
        else
        {
            Console.WriteLine("Not Balanced");
        }
        
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;



/*

1.Time Complexity:
 
  Splitting the string: O(n).
  Appending characters with string: O(n).
  Total: O(n).

2.Space Complexity:

  Split array: O(n).  
  string result: O(n).
  Total: O(n).






*/




class Program
{
   
    public static string MakeString(string str)
    {
        string[] strs=str.Split(' ');
        string result=string.Empty;
        foreach(string s in strs)
        {
            result += s[0];
        }
        return result;
    }
    static void Main()
    {
        string str = "This Is A Test";
        
        Console.WriteLine(MakeString(str));
        Console.ReadLine();
    }

   
   

}
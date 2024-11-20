using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

   public static IEnumerable<string> FriendOrFie(string[] names)
    {
        List<string> result = new List<string>();
       foreach (string name in names)
        {
            if(name.Length==4)
            {
                result.Add(name);
            }
        }
       return result;
    }
    
    static void Main()
    {


       string[] Input = { "Ryan", "Kieran", "Jason", "Yous"};
        foreach (string input in FriendOrFie(Input))
        {
            Console.WriteLine(input);
        }
        Console.ReadLine();
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{

   
    class Program
    {

     
        public static void Main(string[] args)
        {
            string str = "Hello World";

            var uniqueCharactors = str.GroupBy(c => c).Where(group => group.Count() == 1).Select(g => g.Key).ToList();


            Console.WriteLine(string.Join(",",uniqueCharactors));
            Console.ReadLine();
        }
    }
}
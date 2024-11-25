using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{
      class Program
      {

        public static int camelcase(string s)
        {
            int countWordInCamelCase = 0;

            for(int i=0;i<s.Length;i++)
            {
                if (i==0 && Char.IsLower(s[0]))
                    countWordInCamelCase++;
                if (Char.IsUpper(s[i]))
                    countWordInCamelCase++;
            }

            return countWordInCamelCase;
        }
        public static void Main(string[] args)
         {
            string str = "saveChangesInTheEditor";
            Console.WriteLine(camelcase(str));
            Console.Read();  
         }
      }
}
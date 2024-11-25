using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{
      class Program
      {

        static string superReducedString(string s)
        {
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                if(stack.Count==0)
                {
                    stack.Push(s[i]);
                }
                else
                {
                    char temp=stack.Peek();
                    if (temp == s[i])
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                }
            }

            return new string(stack.Reverse().ToArray());

        }
        public static void Main(string[] args)
         {
            //string str = "aab";

           // string str = "aaabccddd";
           // string str = "aa";
           // string str = "baab";
            string str = "aab";

            Console.WriteLine(superReducedString(str));
            Console.Read();  
         }
      }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            s=s.ToLower();
            s = Regex.Replace(s, "[^a-zA-Z0]", string.Empty);
            int count = s.Length-1;
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[count])
                      return false;

                count--;

            }
            return true;
        }
        
    }
}

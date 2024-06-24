using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        
        public static bool IsPalindromeString(string str)
        {
            if (str.Length <= 1)
                return true;

            if (str[0] != str[str.Length - 1])
                return false;

           return IsPalindromeString(str.Substring(1,str.Length-2));


        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter String:");
            string str=Console.ReadLine();
            if(IsPalindromeString(str))
                Console.WriteLine("String is palindrome");
            else
                Console.WriteLine("String is not palindrome");
            Console.ReadLine();
        }
    }

}

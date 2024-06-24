using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {

        public static int CountVowels(string s)
        {
            if (s.Length == 0)
                return 0;

            char firstChar = s[0];
            int count = (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u' ||
                         firstChar == 'A' || firstChar == 'E' || firstChar == 'I' || firstChar == 'O' || firstChar == 'U') ? 1 : 0;

            return count + CountVowels(s.Substring(1));
        }

        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter String:");
            string str=Console.ReadLine();
            Console.WriteLine(CountVowels(str));
           
            Console.ReadLine();
        }
    }

}

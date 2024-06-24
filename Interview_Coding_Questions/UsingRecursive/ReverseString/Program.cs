using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        
        public static string ReverseString(string str)
        {
            if(str.Length<=1)
            {
                return str; 
            }

            return str[str.Length-1] + ReverseString(str.Substring(0,str.Length-1));
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter String:");
            string str=Console.ReadLine();
            Console.WriteLine(ReverseString(str));
            Console.ReadLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        public static int Sum(int n)
        {
            if(n == 0) 
              return 0;

            return n%10+Sum(n/10);
        }

        public static void Main(string[] args) 
        {
            Console.Write("Enter the number of terms: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(num));
            
            Console.ReadLine();
        }
    }

}

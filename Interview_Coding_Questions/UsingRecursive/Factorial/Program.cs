using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        public static int CalFact(int num)
        {
            if (num == 0)
                return 1;

            return num*CalFact(num-1);
        }
      public static void Main(string[] args) 
        {
            int num = 5;
           Console.WriteLine(CalFact(num));
            Console.ReadLine();

        }
    }

}

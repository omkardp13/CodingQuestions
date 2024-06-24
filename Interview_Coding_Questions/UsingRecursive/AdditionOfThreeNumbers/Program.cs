using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        public static int Add(int a,int b)
        {
            if(b==0)
            {
                return a;
            }

            return Add(a + 1, b - 1);
        }

        public static int Addition(int a,int b,int c)
        {
            int FirstTwoNumSum = Add(a,b);

            return Add(FirstTwoNumSum, c);
        }
      public static void Main(string[] args) 
        {
            int num1 = 20;
            int num2 = 30;
            int num3 = 40;
           Console.WriteLine(Addition(num1,num2,num3));
            Console.ReadLine();


        }
    }

}

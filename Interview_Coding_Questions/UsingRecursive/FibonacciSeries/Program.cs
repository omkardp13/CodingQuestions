using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Main(string[] args) 
        {
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.ReadLine();
        }
    }

}

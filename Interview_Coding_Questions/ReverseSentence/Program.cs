using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        
    class program
    {
      public static void Main(string[] args) 
        {
            string sourceString = "my name is onkar dattatray patil";
            string[] arr = sourceString.Split(' ');
            for(int i=0;i<arr.Length/2;i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length-i-1];
                arr[arr.Length - i - 1]=temp;

            }
            string result = String.Join(" ", arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}

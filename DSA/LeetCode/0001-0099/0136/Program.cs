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
        public static int SingleNumber(int[] nums)
        {
            int value = 0;
            for (int i = 0;i<nums.Length;i++)
            {
                value=value ^ nums[i];
            }
            return value;

        }

        public static void Main(string[] args)
        {
            int[] nums = {2, 2, 1};
            
            Console.WriteLine(SingleNumber(nums));
            Console.ReadLine();
        }

    }
}

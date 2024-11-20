using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    /*
     * 
     * Time Complexity: O(n)

       Space Complexity: O(n)
     * 
 
     */
    public static int CountDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        return input
            .ToLower() // Convert the input to lowercase for case-insensitivity
            .GroupBy(c => c) // Group by each character
            .Count(group => group.Count() > 1); // Count groups where the frequency is greater than 1
    }
    static void Main()
    {

        string str = "aabBcde";

        Console.WriteLine(CountDuplicates(str));
        Console.ReadLine();
    }

   
}

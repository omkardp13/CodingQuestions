using System;
using System.Linq;


/*

overall time complexity is O(n).

overall space complexity is O(n).

*/



class Program
{
    static void Main()
    {
        string input = "This Is A Test";
        string result = GetFirstCharacters(input);
        Console.WriteLine(result); // Output: TIAT
    }

    static string GetFirstCharacters(string input)
    {
        // Split the string into words using space as a delimiter, then select the first character of each word.
        return string.Concat(input.Split(' ').Select(word => word[0]));
    }
}

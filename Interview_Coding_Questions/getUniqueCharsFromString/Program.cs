using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Call the method to get unique characters
        List<char> uniqueChars = FindUniqueCharacters(input);

        // Print the unique characters
        Console.WriteLine("Unique characters:");
        foreach (char c in uniqueChars)
        {
            Console.Write(c + " ");
        }
    }

    static List<char> FindUniqueCharacters(string input)
    {
        // Dictionary to count occurrences of each character
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count each character's occurrence in the string
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Filter characters that appeared only once
        List<char> uniqueChars = new List<char>();
        foreach (var pair in charCount)
        {
            if (pair.Value == 1)
            {
                uniqueChars.Add(pair.Key);
            }
        }

        return uniqueChars;
    }
}

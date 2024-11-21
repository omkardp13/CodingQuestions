using System;
using System.Collections.Generic;

public class Program
{
    public static string FirstNonRepeatingLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        // Dictionary to store character frequency (case-insensitive)
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

        // Populate the frequency map (case-insensitive)
        foreach (char c in input)
        {
            char lowerChar = char.ToLower(c);
            if (frequencyMap.ContainsKey(lowerChar))
            {
                frequencyMap[lowerChar]++;
            }
            else
            {
                frequencyMap[lowerChar] = 1;
            }
        }

        // Find the first character with frequency 1 in the original string
        foreach (char c in input)
        {
            if (frequencyMap[char.ToLower(c)] == 1)
            {
                return c.ToString(); // Return the character in original case
            }
        }

        return string.Empty; // No non-repeating character found
    }

    public static void Main()
    {
        Console.WriteLine(FirstNonRepeatingLetter("stress")); // Output: "t"
        Console.WriteLine(FirstNonRepeatingLetter("sTreSS")); // Output: "T"
        Console.WriteLine(FirstNonRepeatingLetter("aabbcc")); // Output: ""
        Console.WriteLine(FirstNonRepeatingLetter("AaBbCcDdEeFfGgHhI")); // Output: "I"
        Console.ReadKey();
    }
}

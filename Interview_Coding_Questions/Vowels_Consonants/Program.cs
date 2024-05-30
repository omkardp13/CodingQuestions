using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        var result = GetVowelsAndConsonants(input);

        Console.WriteLine("Vowels: " + string.Join(", ", result.Item1));
        Console.WriteLine("Consonants: " + string.Join(", ", result.Item2));
        Console.ReadKey();
    }

    static (List<char>, List<char>) GetVowelsAndConsonants(string input)
    {
        List<char> vowels = new List<char>();
        List<char> consonants = new List<char>();

        foreach (char c in input)
        {
            if (IsVowel(c))
            {
                vowels.Add(c);
            }
            else if (IsConsonant(c))
            {
                consonants.Add(c);
            }
        }

        return (vowels, consonants);
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return "aeiou".IndexOf(c) >= 0;
    }

    static bool IsConsonant(char c)
    {
        c = char.ToLower(c);
        return "bcdfghjklmnpqrstvwxyz".IndexOf(c) >= 0;
    }
}

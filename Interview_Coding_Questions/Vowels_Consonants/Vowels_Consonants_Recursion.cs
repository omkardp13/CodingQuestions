using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        var result = GetVowelsAndConsonants(input, 0, new List<char>(), new List<char>());

        Console.WriteLine("Vowels: " + string.Join(", ", result.Item1));
        Console.WriteLine("Consonants: " + string.Join(", ", result.Item2));
        Console.ReadKey();
    }

    static (List<char>, List<char>) GetVowelsAndConsonants(string input, int index, List<char> vowels, List<char> consonants)
    {
        if (index >= input.Length)
        {
            return (vowels, consonants);
        }

        char c = input[index];
        if (IsVowel(c))
        {
            vowels.Add(c);
        }
        else if (IsConsonant(c))
        {
            consonants.Add(c);
        }

        return GetVowelsAndConsonants(input, index + 1, vowels, consonants);
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

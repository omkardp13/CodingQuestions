using System;
using System.Linq;

public class Program
{
    //With Linq Query
    public static void DisplayDuplicatesOccurrence(int[] ints)
    {
        var occurrences = ints.GroupBy(x => x)
                              .Select(g => (Number: g.Key, Count: g.Count()));

        foreach (var pair in occurrences)
        {
            Console.WriteLine($"Number: {pair.Number}, Occurrences: {pair.Count}");
        }
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 4, 5, 6, 4, 2, 6, 8, 5, 3, 2, 3, 4, 5, 6, 2, 6, 8 };
        DisplayDuplicatesOccurrence(numbers);
    }
}


//With Dictionary
/*
 * using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static Dictionary<int, int> CountDuplicatesOccurrence(int[] ints)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        foreach (int i in ints)
        {
            if (keyValuePairs.ContainsKey(i))
            {
                int value = keyValuePairs[i];
                keyValuePairs[i] = ++value;
            }
            else
            {
                keyValuePairs.Add(i, 1);
            }
        }
        
        return keyValuePairs;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 4, 5, 6, 4, 2, 6, 8, 5, 3, 2, 3, 4, 5, 6, 2, 6, 8 };
        Dictionary<int, int> occurrences = CountDuplicatesOccurrence(numbers);

        foreach (var pair in occurrences)
        {
            Console.WriteLine($"Number: {pair.Key}, Occurrences: {pair.Value}");
        }
    }
}

 * 
 */
using System;
using System.Linq;

public class Program
{
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

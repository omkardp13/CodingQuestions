using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[,] array = {
            { 10, 20, 15 },
            { 25, 8, 12 },
            { 30, 16, 18 }
        };

        int k = 4; // Find the 4th smallest element
        int kthSmallest = FindKthSmallest(array, k);

        Console.WriteLine($"{k}th smallest element is: {kthSmallest}");
        Console.Read();
    }

    static int FindKthSmallest(int[,] array, int k)
    {
        // Flatten the 2D array into a list
        List<int> elements = new List<int>();

        foreach (int num in array)
        {
            elements.Add(num);
        }

        // Sort the list
        elements.Sort();

        // Return the k-th smallest element (k-1 because of zero-based index)
        return elements[k - 1];
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] unsortedArray = { 33, 20, 30, 40, 50, 45, 70, 80, 90, 100 };
        int k = 6; // We want the 6th highest number

        if (unsortedArray.Length < k)
        {
            Console.WriteLine("The array does not contain enough elements.");
            return;
        }

        // Step 1: Sort the array in descending order
        Array.Sort(unsortedArray);
        Array.Reverse(unsortedArray);

        // Step 2: Get the 6th highest number
        int sixthHighest = unsortedArray[k - 1]; // k-1 because index is 0-based

        // Step 3: Find the index of the 6th highest number in the original array
        int index = Array.IndexOf(unsortedArray, sixthHighest);

        // Output the result
        Console.WriteLine($"The 6th highest number is {sixthHighest} at index {index} in the original array.");
        Console.ReadKey();
    }
  
}

using System;

class Program
{
    // Bubble sort implementation
    static void SortArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1]) // Swap if the element found is greater than the next element
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] originalArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int k = 6; // We want the 6th highest number

        if (originalArray.Length < k)
        {
            Console.WriteLine("The array does not contain enough elements.");
            return;
        }

        // Step 1: Create a copy of the original array
        int[] copiedArray = (int[])originalArray.Clone();

        // Step 2: Sort the copied array in ascending order using Bubble Sort
        SortArray(copiedArray);

        // Step 3: Get the 6th highest number
        int sixthHighest = copiedArray[copiedArray.Length - k]; // Accessing the 6th highest in sorted array

        // Step 4: Find the index of the 6th highest number in the original array
        int index = Array.IndexOf(originalArray, sixthHighest);

        // Output the result
        Console.WriteLine($"The 6th highest number is {sixthHighest} at index {index} in the original array.");
    }
}

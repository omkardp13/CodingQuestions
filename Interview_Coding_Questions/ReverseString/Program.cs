using System;

class Program
{
    static void Main()
    {
        string str = "Hello World";

        // Convert the string into a character array
        char[] arr = str.ToCharArray();

        // Reverse the array manually using a loop
        for (int i = 0; i < str.Length / 2; i++)
        {
            // Swap characters
            char c = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = arr[i];
            arr[i] = c;
        }

        // Convert the character array back to a string and print it
        Console.WriteLine(new string(arr));  // Output: "dlroW olleH"
        Console.ReadLine();
    }
}

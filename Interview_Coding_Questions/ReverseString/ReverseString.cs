using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);

        Console.WriteLine("Reversed string: " + reversed);
        Console.ReadLine();
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

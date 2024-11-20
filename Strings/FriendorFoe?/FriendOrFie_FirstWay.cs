using System;
using System.Collections.Generic;
using System.Linq;

public class FriendsFilter
{
    public static List<string> GetFriends(List<string> names)
    {
        // Filter the names that have exactly 4 letters
        return names.Where(name => name.Length == 4).ToList();
    }

    public static void Main()
    {
        var input1 = new List<string> { "Ryan", "Kieran", "Jason", "Yous" };
        var output1 = GetFriends(input1);
        Console.WriteLine($"Input: {string.Join(", ", input1)}");
        Console.WriteLine($"Output: {string.Join(", ", output1)}");

        var input2 = new List<string> { "Peter", "Stephen", "Joe" };
        var output2 = GetFriends(input2);
        Console.WriteLine($"Input: {string.Join(", ", input2)}");
        Console.WriteLine($"Output: {string.Join(", ", output2)}");
        Console.Read();
    }
}

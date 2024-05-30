using System;

public class Program
{
    public static void Main()
    {
        string input = "foo bar foo $ bar $ foo bar $ ";

        // Find the positions of all dollar signs
        int firstDollarIndex = input.IndexOf('$');
        int secondDollarIndex = input.IndexOf('$', firstDollarIndex + 1);
        int thirdDollarIndex = input.IndexOf('$', secondDollarIndex + 1);

        // Remove the first and third dollar signs
        if (firstDollarIndex != -1)
        {
            input = input.Remove(firstDollarIndex, 1);
            // Adjust the second and third indexes after removing the first dollar sign
            if (secondDollarIndex > firstDollarIndex) secondDollarIndex--;
            if (thirdDollarIndex > firstDollarIndex) thirdDollarIndex--;
        }

        if (thirdDollarIndex != -1)
        {
            input = input.Remove(thirdDollarIndex, 1);
        }

        Console.WriteLine(input);
        Console.ReadLine();
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "ABCD";
        string str2 = "DCBA";

        // Check if all characters in str1 are present in str2
        bool containsAll = str1.All(c => str2.Contains(c));

        if (containsAll)
        {
            Console.WriteLine("All characters of str1 are contained in str2.");
        }
        else
        {
            Console.WriteLine("Not all characters of str1 are contained in str2.");
        }
        Console.Read();
    }
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Another Way
 * 
 
 
 
        string str1 = "ABCD";
        string str2 = "DCBA";

        bool containsAll = true;

        // Iterate through each character in str1
        for (int i = 0; i < str1.Length; i++)
        {
            char c = str1[i];
            bool found = false;

            // Check if the character exists in str2
            for (int j = 0; j < str2.Length; j++)
            {
                if (c == str2[j])
                {
                    found = true;
                    break; // Exit the inner loop as the character is found
                }
            }

            // If the character is not found, set containsAll to false and break
            if (!found)
            {
                containsAll = false;
                break;
            }
        }

        if (containsAll)
        {
            Console.WriteLine("All characters of str1 are contained in str2.");
        }
        else
        {
            Console.WriteLine("Not all characters of str1 are contained in str2.");
        }

 
 
 
 
 
 
 
 */


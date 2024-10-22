1.Reverse String 
--->

/* In-built Function
  Console.WriteLine("Enter Source String:");
 string SourceString=Convert.ToString(Console.ReadLine());
 char[] chars = SourceString.ToCharArray();
 Array.Reverse(chars);
 Console.WriteLine(new string(chars));
 Console.ReadLine();

*/

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

/* Time Complexity O(n/2)
Console.WriteLine("Enter Source String:");
string SourceString = Convert.ToString(Console.ReadLine());

char[] chars = SourceString.ToCharArray();

for (int i = 0; i < chars.Length/2; i++)
{
    char c = chars[i];
    chars[i] = chars[chars.Length-i-1];
    chars[chars.Length - i - 1] = c;
}

Console.WriteLine(new string(chars));
Console.ReadLine();
*/
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Time Complexity O(n/2)
Console.WriteLine("Enter Source String:");
string SourceString = Convert.ToString(Console.ReadLine());

char[] chars = SourceString.ToCharArray();

int start = 0;
int end=chars.Length-1;

while (start < end) 
{
    char c = chars[start];
    chars[start] = chars[end];
    chars[end]=c; 
    start++;
    end--;
}

Console.WriteLine(new string(chars));
Console.ReadLine();

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.Check for Palindrome: Write a function to check if a given string is a palindrome or not.
--->
n C#, a palindrome number is a number that is the same when read forward or backward. For example, 121, 34543, 343, 131, and 48984 are all palindrome numbers.

    public static bool isStringPalindrome(string inputString)
    {
        for (int i = 0; i < inputString.Length / 2; i++)
        {
            if (inputString[i] != inputString[inputString.Length - i - 1])
                return false;
           
        }
        return true;
    }
}
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public bool IsPalindrome(string str)
{
    int left = 0;
    int right = str.Length - 1;
    
    while (left < right)
    {
        if (str[left] != str[right])
            return false;
        
        left++;
        right--;
    }
    
    return true;
}
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


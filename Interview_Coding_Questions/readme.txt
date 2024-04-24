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
*/


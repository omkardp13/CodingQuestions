28:Find the index of the first occurence in a string

Approach:
-----------------------------------------------------------------------------------------------------------------------------------------------
This implementation is aimed at finding the first occurrence of the substring needle within the string haystack. The solution is broken down into two methods:

Main Method StrStr:

Edge Case Check: If haystack is smaller than needle, it immediately returns -1 because the needle can't be found.
Iteration: It iterates through each character in haystack with a for loop. For each character, if it matches the first character of the needle, it calls the helper method CompareStrings to check if the entire substring matches the needle.
Return: If a match is found, it returns the starting index; otherwise, it continues the loop. If no match is found by the end of the loop, it returns -1.
Helper Method CompareStrings:

Bounds Check: Before comparing, it checks if the substring of haystack starting from the current index is long enough to contain needle. If not, it returns false.
Character Comparison: It compares the characters of haystack and needle one by one. If any character doesn't match, it returns false. If all characters match, it returns true.
Time Complexity:
Worst-case Time Complexity: O(m * n), where m is the length of haystack and n is the length of needle.

In the worst case, the algorithm might need to compare the needle with every possible starting position in haystack. For each starting position, comparing the strings takes O(n) time (in the helper method CompareStrings). Therefore, the total complexity is O(m * n).
Best-case Time Complexity: O(m), where m is the length of haystack.

In the best case, the first character match is immediately found at the beginning, and the needle is fully matched, leading to a linear scan.
Space Complexity:
The space complexity is O(1) because the algorithm only uses a constant amount of extra space (e.g., counters and indices) regardless of the input size.
Detailed Example:
Consider haystack = "abracadabra" and needle = "cad":

Start iterating over haystack. When the index is 4, the character 'c' matches the first character of needle.
Call CompareStrings(4, haystack, needle) to compare the substring "cad" with needle.
The comparison succeeds, so the function returns the index 4.
If needle = "xyz" was passed, the loop would finish without finding a match, and the function would return -1.

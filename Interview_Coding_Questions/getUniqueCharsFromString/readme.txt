Time Complexity
Counting Occurrences (First Loop):

The program iterates through each character in the input string exactly once to count occurrences. This takes 
𝑂
(
𝑛
)
O(n), where 
𝑛
n is the length of the input string.
Filtering Unique Characters (Second Loop):

After counting occurrences, the program iterates over the dictionary to collect characters that appear only once. Since the dictionary can contain up to 
𝑛
n entries (in the case of all unique characters), this loop also takes 
𝑂
(
𝑛
)
O(n) time in the worst case.
Overall, the time complexity is:

𝑂
(
𝑛
)
+
𝑂
(
𝑛
)
=
𝑂
(
𝑛
)
O(n)+O(n)=O(n)
So, the time complexity is 
𝑂
(
𝑛
)
O(n).

Space Complexity
Dictionary for Character Counts:

The dictionary stores each unique character with its count. In the worst case, where all characters in the string are unique, the dictionary would require 
𝑂
(
𝑛
)
O(n) space.
List for Unique Characters:

The list of unique characters also requires 
𝑂
(
𝑛
)
O(n) space in the worst case, where all characters are unique.
Therefore, the space complexity is 
𝑂
(
𝑛
)
O(n).

Summary
Time Complexity: 
𝑂
(
𝑛
)
O(n)
Space Complexity: 
𝑂
(
𝑛
)
O(n)

66.Plus One

You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
 

Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's.
-------------------------------------------------------------------------------------------------------------------------------------------------
Approach:
The task is to add one to a non-negative integer represented as an array of digits, where the most significant digit is at the start of the array.

Iterate from the last digit: Start from the least significant digit (rightmost) and move towards the most significant digit (leftmost).
Check the digit:
If the current digit is less than 9, simply increment it by one and return the updated array because no further carry is required.
If the current digit is 9, set it to 0 (since adding 1 results in a carry that needs to be added to the next higher digit).
Handle carry at the most significant digit: If all the digits are 9 (e.g., [9, 9, 9]), after the loop, the array will be filled with zeros. In this case, a new array with an additional element is created, with the first element set to 1 (e.g., [1, 0, 0, 0]).
Example:
For input [9, 9, 9]:

Step 1: Set the last 9 to 0 and carry over.
Step 2: Set the second-to-last 9 to 0 and carry over.
Step 3: Set the first 9 to 0 and carry over.
Step 4: Since all digits have been processed and a carry remains, create a new array [1, 0, 0, 0].
Time Complexity:
O(n): You iterate through the array once from the end to the beginning, where n is the number of digits in the input array. In the worst case (when all digits are 9), the loop runs for all n digits.
Space Complexity:
O(1): The algorithm modifies the input array in place without using any additional space (apart from a constant amount of space for the new array in the edge case where all digits are 9). The worst-case space complexity becomes O(n) when all digits are 9, and a new array of size n+1 is created.

7.Reverse Integer.

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
 

Constraints:

-231 <= x <= 231 - 1
------------------------------------------------------------------------------------------------------------------------------------------------
Explanation:
The while loop continues until temp becomes 0. In each iteration, we are effectively removing one digit from temp by performing the division operation temp = temp / 10.
The number of iterations of the loop depends on the number of digits in the input integer x.
An integer x has approximately log₁₀(x) digits.
Therefore, the loop runs in O(log₁₀(x)) time.
Space Complexity:
The space complexity is O(1) since we are using a constant amount of extra space (for variables like temp, res, and rem).

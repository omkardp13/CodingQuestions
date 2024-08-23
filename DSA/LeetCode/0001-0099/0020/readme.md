20.Valid Parentheses.

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.


Approch--->
-----------------------------------------------------------------------------------------------------------------------------------------------
Stack Data Structure:

1.A stack is used to store opening brackets as they appear.
Whenever a closing bracket is encountered, the algorithm checks if it corresponds to the last opened bracket (by checking the top of the stack). If it matches, the last opened bracket is removed (popped from the stack).
If it doesn't match or the stack is empty when a closing bracket is encountered, the string is considered invalid.
Iterating through the String:

2.The algorithm iterates through the string character by character.
For each character, if it's an opening bracket, it gets pushed onto the stack.
If it's a closing bracket, it checks if the stack is empty (invalid case) or if the top of the stack matches the corresponding opening bracket. If it matches, the bracket is popped from the stack.

Final Check:
3.After processing all characters, if the stack is empty, the string is valid. If the stack is not empty, it means there are unmatched opening brackets, so the string is invalid.

Time Complexity --->
-----------------------------------------------------------------------------------------------------------------------------------------------
Time Complexity:
The code iterates through the string once using a for loop, so the time complexity of the loop is O(n), where n is the length of the string str.

Space Complexity:
The space complexity is determined by the stack st.
In the worst case, if all characters in the string are opening brackets ((, {, [), the stack will hold all of them. This means the space used by the stack can grow up to O(n), where n is the length of the string.

Thus, the space complexity is O(n) in the worst case.

Summary:
Time Complexity: 
O(n)
Space Complexity: 
O(n)

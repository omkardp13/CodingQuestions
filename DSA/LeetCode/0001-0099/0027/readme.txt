27.Remove Element
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int val = ...; // Value to remove
int[] expectedNums = [...]; // The expected answer with correct length.
                            // It is sorted with no values equaling val.

int k = removeElement(nums, val); // Calls your implementation

assert k == expectedNums.length;
sort(nums, 0, k); // Sort the first k elements of nums
for (int i = 0; i < actualLength; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2,_,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).
 

Constraints:

0 <= nums.length <= 100
0 <= nums[i] <= 50
0 <= val <= 100
----------------------------------------------------------------------------------------------------------------------------------------------------
Approach:
The problem you're solving involves removing all instances of a specified value (val) from an integer array (nums). The goal is to do this in-place and return the new length of the array after removal.

Initialization:

A counter (counter) is initialized to 0. This will keep track of the position where the next non-val element should be placed.
Iterate through the array:

Use a for loop to iterate through all elements of the nums array.
Check each element:

If the current element (nums[i]) is not equal to the target value (val), assign it to nums[counter] and increment the counter.
If it is equal to val, skip it (do nothing).
Return the result:

After the loop, the counter will represent the number of elements in the array that are not equal to val. The first counter elements of nums will be the new array after removal.
Time Complexity:
The time complexity of this solution is O(n), where n is the length of the nums array. This is because you are iterating through the array exactly once.
Space Complexity:
The space complexity is O(1), because you are modifying the array in place and using only a constant amount of extra space (the counter variable).
This is a standard two-pointer technique where one pointer (i) traverses the array, and the other pointer (counter) keeps track of the position for the next valid element.

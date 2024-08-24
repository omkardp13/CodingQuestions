26.Remove Duplicates From Sorted Array
-----------------------------------------------------------------------------------------------------------------------------------------------
Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int[] expectedNums = [...]; // The expected answer with correct length

int k = removeDuplicates(nums); // Calls your implementation

assert k == expectedNums.length;
for (int i = 0; i < k; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
 

Constraints:

1 <= nums.length <= 3 * 104
-100 <= nums[i] <= 100
nums is sorted in non-decreasing order.
--------------------------------------------------------------------------------------------------------------------------
Approach:
This code implements an efficient solution to remove duplicates from a sorted array nums, modifying it in-place such that each element appears only once. The method returns the number of unique elements in the modified array.

Here's the step-by-step approach:

Initialization:

Two pointers left and right are initialized to 0. The left pointer represents the position of the last unique element in the array, while the right pointer traverses the array.
Iteration through the array:

The right pointer traverses through the array starting from index 0.
If the element at nums[right] is not equal to nums[left] (i.e., a new unique element is found), the element is placed at nums[left + 1]. This means that the unique elements are shifted to the left side of the array, and left is incremented.
End of iteration:

Once the loop completes, the number of unique elements is left + 1.
Return:

The method returns left + 1, which is the count of unique elements in the modified array.
Example:
Input: [1, 1, 2, 2, 3, 3]

After processing, the array becomes [1, 2, 3, 2, 3, 3].
The function returns 3, which is the count of unique elements [1, 2, 3].

Time Complexity:
-----------------------------------------------------------------------------------------------------------------------------------------------
Time complexity: O(n), where n is the length of the array. The reason is that we are iterating through the array once with the right pointer.

Space complexity: O(1) because we are modifying the array in-place and not using any extra space.

This approach is efficient and optimal for the problem of removing duplicates from a sorted array.



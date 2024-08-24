35.Search Insert Position.

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104

-----------------------------------------------------------------------------------------------------------------------------------------------

Approach:
Binary Search:
You are given a sorted array arr and a target value.
The goal is to find the index where the target should be inserted to maintain the sorted order.
You initialize two pointers, left and right, representing the start and end of the array.
While left is less than or equal to right, calculate the middle index mid.
If the middle element arr[mid] equals the target, return mid.
If arr[mid] is less than target, update left to mid + 1 (search in the right half).
If arr[mid] is greater than target, update right to mid - 1 (search in the left half).
When the loop exits, left will be the insertion position for the target.


Time Complexity:
O(log n): The binary search algorithm halves the search space with each iteration, leading to a logarithmic time complexity. This is much more efficient than a linear search, especially for large arrays.
Here, n is the number of elements in the array.

Space Complexity:
O(1): The space complexity is constant because the algorithm only uses a few extra variables (left, right, and mid) and does not require additional space proportional to the input size.

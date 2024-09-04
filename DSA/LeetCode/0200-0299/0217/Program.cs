using System;
using System.Collections.Generic;


public class Solution
{

    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>();

        for(int i=0;i<nums.Length;i++)
        {
            if (visited.Contains(nums[i]))
                return true;
            else
                visited.Add(nums[i]);
        }

        return false;
    }


    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 1 };
        ContainsDuplicate(nums);


    }
}
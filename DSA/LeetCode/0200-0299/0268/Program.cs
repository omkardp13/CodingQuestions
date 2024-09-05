using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

public class Solution
{

    public static int MissingNumber(int[] nums)
    {
        int sum = 0;

        for(int i=0;i<nums.Length;i++)
        {
            sum += nums[i];
        }

        int ActualSum = nums.Length * (nums.Length + 1) / 2;

        return ActualSum - sum;
    }


}
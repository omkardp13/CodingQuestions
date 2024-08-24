using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static int RemoveDuplicates(int[] nums)
    {
        int left = 0, right =0;
       
        while(right < nums.Length)
        {
            if(nums[left] != nums[right])
            {
                nums[left + 1] = nums[right];
               
                left++;     
            }          
            right++;
        }

        return left+1;
    }
}
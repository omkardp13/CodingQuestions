using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

public class Solution
{

    public static int MajorityElement(int[] nums)
    {
        Dictionary<int,int> result = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (result.ContainsKey(nums[i]))
            {
                result[nums[i]]++;
            }
            else
            {
                result[nums[i]] = 1;
            }
        }

        foreach(var item in result)
        {
            if(item.Value>=(nums.Length)/2)
            {
                return item.Key;
            }
        }

        return 0;
    }

    public static void Main()
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        Console.WriteLine(MajorityElement(nums));
        Console.ReadLine();
    }

}
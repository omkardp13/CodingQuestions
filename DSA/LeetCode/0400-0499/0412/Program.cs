﻿using System;
using System.Collections.Generic;


public class Solution
{
    public static IList<string> FizzBuzz(int n)
    {
        List<string> list = new List<string>();

        for (int i = 1;i<=n;i++)
        {
            if(i%3==0 && i % 5 == 0)
            {
                list.Add("FizzBuzz");
            }
            else if(i%3==0)
            {
                list.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                list.Add("Buzz");
            }
            else
            {
                list.Add(i.ToString());
            }
        }

        return list;
    }

    public static void Main(string[] args)
    {
        int n = 3;
        FizzBuzz(n);
        
    }
}
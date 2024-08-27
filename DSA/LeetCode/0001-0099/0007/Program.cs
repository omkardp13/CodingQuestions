using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

public class Solution
{

   
    public static int Reverse(int x)
    {

       

        int temp = x;
        int res = 0;
        while(temp!=0)
        {
            int rem = temp % 10;
            res = res * 10+rem;

            if(res<int.MinValue/10 && res>int.MaxValue/10)
            {
                return 0;
            }
            temp = temp / 10;
        }

        return res;
    }

}
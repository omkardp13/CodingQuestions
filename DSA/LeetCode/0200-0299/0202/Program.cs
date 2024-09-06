using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


public class Solution
{

    public static bool IsHappy(int n)
    {
        int sum = 0;
        int temp = n;
        HashSet<int> seenSums = new HashSet<int>();

        while (sum!=1)
        {

            if(seenSums.Contains(sum))
                return false;

            seenSums.Add(sum);
            sum = 0;            
            while (temp!=0)
             {
                int rem = temp % 10;
                sum =sum+ rem * rem;
                temp=temp/10;
             }
          
            temp = sum;           
        }

        return true;
    }

    public static void Main(string[] args)
    {
        int n = 7;
        if(IsHappy(n))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.ReadKey();
    }
}
using System;
using System.Text;

class Program
{

    public static void DisplayPrimeNumbers(int n)
    {
        bool isPrime = true; ;
         for (int i = 2; i < n; i++) 
         {
            for (int j = 2;j < i;j++)
            {
                if(i%j==0)
                {
                    isPrime = false;
                    break;
                }

            }
            if(isPrime)
             Console.WriteLine(i);

            isPrime = true;
         }
    }
    

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int num=Convert.ToInt32(Console.ReadLine());
        DisplayPrimeNumbers(num);
        Console.Read();
    }
}

using System;
using System.Text;

class Program
{

    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if(num %i==0)
            {
                return false;
            }

        }
        return true;
    }
    

    public static void Main(string[] args)
    {
        int counter = 0;
        int num = 2;
        
        while (counter!=5) 
        {
            if(IsPrime(num))
            {
                Console.WriteLine(num);
                counter++;
            }
            num++;  
            
        }
        Console.ReadKey();
    }
}

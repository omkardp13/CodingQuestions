/*

using System;

public class Program
{

 
    public static void DisplayFibonacciSeries(int num)
    {
        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        int a = 0, b = 1;
        Console.WriteLine("Fibonacci Series:");

        if (num >= 1)
            Console.WriteLine(a);
        if (num >= 2)
            Console.WriteLine(b);

        for (int i = 2; i < num; i++)
        {
            int c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            DisplayFibonacciSeries(num);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        Console.Read();
    }
}




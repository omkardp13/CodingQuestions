using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{
      class Program
      {

        public static int minimumNumber(int n, string password)
        {
            int numberOfCharactorsNeed = 0;

           


            bool isDigitContainInPassword=password.Any(x => Char.IsDigit(x));
            
            if(!isDigitContainInPassword)
                numberOfCharactorsNeed++;

            bool isLowerLetterContainInPassword = password.Any(x => Char.IsLower(x));

            if (!isLowerLetterContainInPassword)
                numberOfCharactorsNeed++;

            bool isUpperLetterContainInPassword= password.Any(x => Char.IsUpper(x));

            if(!isUpperLetterContainInPassword)
            {
                numberOfCharactorsNeed++;
            }

            char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'};
            bool isSpecialLetterContainInPassword = password.Any(x => specialChars.Contains(x));

            if (!isSpecialLetterContainInPassword)
            {
                numberOfCharactorsNeed++;
            }

            // Ensure the total length is at least 6
            int lengthDifference = Math.Max(0, 6 - n);

            // Return the maximum of missing types and length difference
            return Math.Max(numberOfCharactorsNeed, lengthDifference);

        }

        public static void Main(string[] args)
         {
            string str = "1z2!";
            int n= 4;
            Console.WriteLine(minimumNumber(n, str));
            Console.Read();  
         }
      }
}

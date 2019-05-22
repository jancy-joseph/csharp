using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class PalindromeNumber
    {
        public static void isPalindrome(int num)
        {
            int n = num;
            //StringBuilder sb = new StringBuilder();
            //while (n > 0)
            //{
            //    sb.Append(n % 10);
            //    n = n / 10;
            //}
            //int reversed = int.Parse(sb.ToString());
            int reversed = 0;
            while( n > 0)
            {
                reversed = reversed * 10 + (n % 10);
                n = n / 10;

            }

            if(reversed == num)
            {
                Console.WriteLine("Is Palindrome");
                return;
            }
            Console.WriteLine("Not Palindrome");
            return;
        }

    }
}

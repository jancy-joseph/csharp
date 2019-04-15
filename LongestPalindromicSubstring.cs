using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class LongestPalindromicSubstring
    {
        public static bool CheckPalindrome(string st, int start, int end)
        {
            char[] str = st.ToCharArray();
            int mid = start + end / 2;
            int end1 = end;
            if(mid %2 == 0)
            {
                for (int i = start; i <= mid; i++)
                {
                    char temp = str[i];
                    str[i] = str[end1];
                    str[end1--] = temp;
                }

            }
            else
            {
                for (int i = start; i < mid; i++)
                {
                    char temp = str[i];
                    str[i] = str[end1];
                    str[end1--] = temp;
                }

            }
            
            if (string.Equals(new string(str), st))//its a palindrome
            {
                Console.WriteLine("Hurray {0}", st.Substring(start, end));
                return true;
            }
            Console.WriteLine("old {0}",st);
            Console.WriteLine("new  {0}",new string(str));

            return false;
                                       
        }
        public static void LongestPalDrmSubstring(string s)
        {
            for(int i =0; i <s.Length -1; i++)
            {
                for(int j = s.Length -1; j>i; j --)
                {
                    if (s[i] == s[j])
                    {
                        var result = CheckPalindrome(s, i, j);
                        if(result)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class stringManipulation
    {
        public static string removeDuplicates(string s)
        {
            char[] sarr = s.ToCharArray();
            int k = 1;
            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = 0; i < sarr.Length; i++)
            {

                if (sarr[i] == sarr[i + 1])
                {
                    while (i + 1 < sarr.Length && sarr[i] == sarr[i + 1])
                    {
                        i++;
                    }
                    sb.Insert(k, sarr, i, 1);
                    k++;
                    //sb[k++] = sarr[i];

                }
                else
                {
                    sb.Insert(k - 1, sarr, i, 1);
                    k++;
                    // sb[k-1] = s[i];

                }


            }
            return sb.ToString();
        }

        public static List<string> findUniqueSubstrings(string s , int k )
        {
            List<string> l1 = new List<string>();
            if (s == null || s.Length == 0 || s.Length < k)
            {
                l1.Add("");
                return l1;
            }
            bool isUniqueSubstring = true;
            Dictionary<char, int> dcharmap = new Dictionary<char, int>();
            char[] chr = s.ToCharArray();

            //Console.WriteLine((chr.Length - k));

            for (int i =0; i< (chr.Length-k+1); i++)//here k+1 as we need to consider array of exactly k elements
            {
                dcharmap.Clear();
                isUniqueSubstring = true;
                for (int j =i; j<(i+k); j++)
                {
                    if (!dcharmap.ContainsKey(chr[j]))// if dictioanry doesnot have character in it
                    {
                        dcharmap[chr[j]] = 1;
                    }
                    else
                    {
                        isUniqueSubstring = false;
                        break;
                    }
                }
                if (isUniqueSubstring)
                {
                    string str = s.Substring(i, k);
                    l1.Add(str);



                }
            }
            return l1;
        }
    }
}

                                                         
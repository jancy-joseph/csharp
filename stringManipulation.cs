using System;
using System.Collections.Generic;
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
    }
}

                                                         
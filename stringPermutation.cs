using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class stringPermutation
    {
        public static void Permute(string s)
        {
            //Console.WriteLine(s);
            //Console.WriteLine(s.Remove(0, 1));
            //Console.WriteLine(s);
            //Console.WriteLine(s.Remove(1, 1));
            //Console.WriteLine(s);
            //Console.WriteLine(s.Remove(2, 1));

             PermuteHelper(s,"");
        }
        public static void PermuteHelper(string s, string chosen)
        {
            if(s.Length == 0)//exit criteria for recursion
            {
                Console.WriteLine(chosen);
            }
            else
            {
                for(int i =0; i <s.Length; i++)
                {
                    //choose
                    char c = s[i];
                    chosen += c;//add char to chosen
                    s = s.Remove(i,1);

                    //explore
                    PermuteHelper(s, chosen);

                    //undo choosing
                    s = s.Insert(i, c.ToString());
                    chosen = chosen.Remove(chosen.Length - 1, 1);//last apppended character removed
                                                                          
                }

            }
        }
    }
}

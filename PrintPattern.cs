using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class PrintPattern
    {
        public static void retOddEven(char[] arr,out char[] odd,out char[] even)
        {
            int j = 0;
            int k = 0;

            odd = new char[(arr.Length / 2) +1];
            even = new char[(arr.Length / 2)+1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[j++] = arr[i];
                }
                else
                {
                    odd[k++] = arr[i];
                }
            }

            return;
        }
        public static void printSineWave(string s)
        {
            if (s == null||s.Length ==0 )
            {
                Console.WriteLine("");
            }
            if (s.Length == 1)
            {
                Console.WriteLine(s[0]);
            }

            int j = 0;
            int k = 0;
            char[] str = s.ToCharArray();
            char[] odd;
            char[] even; 

            retOddEven(str,out odd,out even);
            char[] oddodd;
            char[] oddeven;
            retOddEven(odd, out oddodd,  out oddeven);
            char[] oddevenprint = new char[str.Length*2];
            char[] oddoddprint = new char[str.Length*2];
            char[] evenprint = new char[str.Length * 2];
            for(int i =0; i <oddeven.Length; i++)
            {
                if(i == 0)
                {
                    oddevenprint[k++] = ' ';
                    oddevenprint[k++] = oddeven[i];
                    //Console.Write((' ' * 1 + oddeven[i]).ToString());
                }
                else
                {
                    oddevenprint[k++] = ' ';
                    oddevenprint[k++] = ' ';
                    oddevenprint[k++] = ' ';
                    oddevenprint[k++] = oddeven[i];
                    //Console.Write((' ' * 3 + oddeven[i]).ToString());
                }
            }
            Console.WriteLine(new string(oddevenprint));
            for(int i = 0; i < even.Length; i++)
            {
                
                evenprint[j++] = even[i];
                evenprint[j++] = ' ';
                // Console.Write((' ' * 1 + even[i]).ToString());
            }
            Console.WriteLine(new string(evenprint));
            int l = 0;
            for(int i = 0; i<oddodd.Length; i++)
            {
                oddoddprint[l++] = ' ';
                oddoddprint[l++] = ' ';
                oddoddprint[l++] = ' ';
                oddoddprint[l++] = oddodd[i];
               // Console.Write((' ' * 3 + oddodd[i]).ToString());
            }
            Console.WriteLine(new string(oddoddprint));
        }
    }
}

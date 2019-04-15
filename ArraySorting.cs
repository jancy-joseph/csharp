using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
     public  static class ArraySorting
    {
        public static void sortIntArray()
        {
            

           /// Using Array.Sort()
                
            
            int[] arr = new int[5] { 10, 4, 5, 2, 10 };
            //Array.Sort(arr);
            //var arrLinq = (from val in arr select val).ToList().foreach(System.Console.Write(val)) ;
            //foreach (int val in arr) Console.Write(val);

            // sort string array
            //string[] stringArray = new string[5] { "Csharp", "ASP.net", "EntityFramework", "ADO.net", "WCF" };
            //Array.Sort(stringArray);
            // write array
            //foreach (string str in stringArray) Console.Write(str + " ");


            ///Using Icomparable Interface
            ///
            ///using Icomaprer interface
            ///
            ///using Linq
            ///
            //var list = arr.OrderBy(val => val).Reverse();
            //foreach (int val1 in list) Console.WriteLine(val1);

            var arrlist = from val in arr
                          where (val > 10)
                          select val;
            foreach(int val1 in arrlist)Console.WriteLine(val1);

            //Parallel linq;
            var arrlist1 = from val in arr.AsParallel()
                          where val > 2
                          select val;
            foreach (int val1 in arrlist) Console.WriteLine(val1);




        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class Equilibrum_Index
    {
        public static int FindEquilibriumIndex(int[] arr)
        {
            if (arr == null | arr.Length < 3)
            {
                Console.WriteLine("Not enough elements in array to find Equilibrium index");
                return -1;
            }
            int left_sum = 0;
            int right_sum = arr.Length - 1;

            
        }
    }
}

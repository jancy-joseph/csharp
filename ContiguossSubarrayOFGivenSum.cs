using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    public static class ContiguossSubarrayOFGivenSum
    {
        public static int[] FindSubArrayGivenSum_NonNegativeNos(int[] arr, int target_sum)
        {
            // array was not intiialized or array has no elements
            if (arr == null || arr.Length == 0)
                return null;
            //if array has only one 
            if (arr.Length == 1)
            {
                if (arr[0] != target_sum)
                {
                    return null;
                }
                else
                {
                    return new int[] { 0, 0 };
                }
            }
            int curr_sum = 0;
            int start_index = 0;
            int end_index = 0;
            while (end_index <= arr.Length - 1)
            {
                if (curr_sum < target_sum)
                {
                    curr_sum += arr[end_index++];
                }
                else if (curr_sum > target_sum)
                {
                    curr_sum -= arr[start_index++];
                }
                else
                {
                    return new int[] { start_index, end_index };
                }
            }
            //didnot find a contiguous subarray leading a target_sum in the array
            return null;
        }
        public static void FindSubArrayGivenSum_Manjusha(int[] arr, int target_sum)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int curr_sum = 0, end_index = 0, start_index = 0;
                curr_sum = arr[i];
                while (curr_sum > target_sum && start_index < end_index)
                {
                    curr_sum = curr_sum - arr[start_index];
                    end_index++;
                }
                if (curr_sum == target_sum)
                {
                    end_index = i;
                }
                else if (end_index < arr.Length - 1)
                {
                    curr_sum = curr_sum + arr[end_index];
                }
                Console.WriteLine("Strt_index{0},End_index{1}", start_index, end_index);

            }
        }
    }

}

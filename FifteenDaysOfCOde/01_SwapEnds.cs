using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/18/2021--
        Days of Code: Day[0]
        Exercise 1: SwapEnds
        Create an integer array method called SwapEnds that takes in an integer array "nums". Given an array of ints, swap the first and last elements in the array. Return the modified array. The array length will be at least 1.
        For example:
        swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
        swapEnds([1, 2, 3]) → [3, 2, 1]
        swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
        */

        public int[] SwapEnds(int[] nums)
        
        {
        int[] result = new int[nums.Length];

        if (nums == null || nums.Length < 2)
        {
            return nums;
        }
        else
        {
            result[0] = nums[nums.Length - 1];
            result[result.Length - 1] = nums[0];

            if (nums.Length > 2)
            {
                for (int i = 1; i < nums.Length - 1; i++)
                {
                    result[i] = nums[i];
                }
            }
            return result;
        }
        }
    }
}




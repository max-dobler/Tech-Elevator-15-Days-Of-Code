using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/4/2021--
        Days of Code: Day 11
        Exercise 11: MakeMiddle
        Create an integer array method called MakeMiddle that takes in an integer array “nums”. Given an array of ints of even length, return a new array length 2 containing the middle two elements from the original array. The original array will be length 2 or more.
        makeMiddle([1, 2, 3, 4]) → [2, 3]
        makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
        makeMiddle([1, 2]) → [1, 2]
        */

        public int[] MakeMiddle(int[] nums)
        {
            int[] result = new int[]
            {
                nums[(nums.Length / 2) - 1],
                nums[nums.Length / 2]
            };
            return result;
        }
    }
}

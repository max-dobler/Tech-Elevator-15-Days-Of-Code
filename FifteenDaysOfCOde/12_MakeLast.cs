using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/5/2021--
        Days of Code: Day[12]
        Exercise 12: MakeLast
        Create an integer array method called MakeLast that takes in an integer array “nums”. Given an int array, return a new array with double the length where its last element is the same as the original array, and all the other elements are 0. The original array will be length 1 or more. Note: by default, a new int array contains all 0's.
        MakeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
        MakeLast([1, 2]) → [0, 0, 0, 2]
        MakeLast([3]) → [0, 3]
        */

        public int[] MakeLast(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            result[result.Length - 1] = nums[nums.Length - 1];
            return result;
        }
    }
}

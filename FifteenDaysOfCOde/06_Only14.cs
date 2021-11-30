using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/25/2021--
        Days of Code: Day[6]
        Exercise 6: Only14
        Create a boolean method called Only14 that takes in an integer array “nums”. Given an array of ints, return true if every element is a 1 or a 4.
        only14([1, 4, 1, 4]) → true
        only14([1, 4, 2, 4]) → false
        only14([1, 1]) → true         
        */

        public bool OnlyOneFour(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            foreach (int num in nums)
            {
                if (num != 1 && num != 4)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

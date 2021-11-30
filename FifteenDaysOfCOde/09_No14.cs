using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/4/2021--
        Days of Code: Day 09
        Exercise 9: No14
        Create a boolean method called No14 that takes in an integer array “nums”. Given an array of ints, return true if it contains no 1's and it contains no 4's.
        no14([7, 2, 3]) → true
        no14([1, 2, 3, 4]) → false
        no14([2, 3, 4]) → false
        */

        public bool NoOneFour(int[] nums)
        {
            if (nums == null)
            {
                return true;
            }

            foreach (int num in nums)
            {
                if (num == 1 || num == 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

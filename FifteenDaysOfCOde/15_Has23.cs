using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/7/2021--
        Days of Code: Day[15]
        Exercise 15: Has23
        Create a boolean method called Has23 that takes in an integer array “nums”. Given an int array length 2, return true if it contains a 2 or a 3.
        has23([2, 5]) → true
        has23([4, 3]) → true
        has23([4, 5]) → false
        */

        public bool HasTwoThree(int[] nums)
        {
            if (nums == null)
            {
                return false;
            }

            foreach (int num in nums)
            {
                if (num == 2 || num == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

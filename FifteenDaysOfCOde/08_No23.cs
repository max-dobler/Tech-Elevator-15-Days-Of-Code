using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/27/2021--
        Days of Code: Day 08
        Exercise 8: No23
        Create a method of type boolean called No23 that takes in an integer array “nums”. Given an int array length 2, return true if it does not contain a 2 or 3.
        no23([4, 5]) → true
        no23([4, 2]) → false
        no23([3, 5]) → false
        */

        public bool NoTwoThree(int[] nums)
        {
            if (nums == null)
            {
                return true;
            }

            foreach (int num in nums)
            {
                if (num == 2 || num == 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

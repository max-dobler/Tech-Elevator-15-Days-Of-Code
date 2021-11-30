using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/26/2021--
        Days of Code: Day[7]
        Exercise 7: NoTriples
        Create a boolean method called NoTriples that takes in an integer array “nums”.  Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. Return true if the array does not contain any triples.
        noTriples([1, 1, 2, 2, 1]) → true
        noTriples([1, 1, 2, 2, 2, 1]) → false
        noTriples([1, 1, 1, 2, 2, 2, 1]) → false
        */

        public bool NoTriples(int[] nums)
        {
            int consecutiveNumberCount = 0;

            if (nums == null || nums.Length < 3)
            {
                return true;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    consecutiveNumberCount++;
                }
                else
                {
                    consecutiveNumberCount = 0;
                }

                if (consecutiveNumberCount == 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

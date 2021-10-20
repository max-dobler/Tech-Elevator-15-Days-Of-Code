using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/19/2021--
        Days of Code : Day 2
        Exercise 2:   Has12
        Create a boolean method called Has12 that takes in an integer array "nums". Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.
        For example:
        has12([1, 3, 2]) → true
        has12([3, 1, 2]) → true
        has12([3, 1, 4, 5, 2]) → true
        */

        public bool HasTwelve(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

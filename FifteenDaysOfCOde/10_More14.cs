using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/4/2021--
        Days of Code: Day[10]
        Exercise 10: More14
        Create a boolean method called More14 that takes in an array of type integer “nums”. Given an array of ints, return true if the number of 1's is greater than the number of 4's
        more14([1, 4, 1]) → true
        more14([1, 4, 1, 4]) → false
        more14([1, 1]) → true
        */

        public bool MoreOneFour(int[] nums)
        {
            int numOnes = 0;
            int numFours = 0;

            if (nums == null)
            {
                return false;
            }

            foreach (int num in nums)
            {
                if (num == 1)
                {
                    numOnes++;
                }
                if (num == 4)
                {
                    numFours++;
                }
            }

            return numOnes > numFours;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/21/2021--
        Days of Code: Day 4
        Exercise 4: Start1
        Create an integer method called Start1 that takes in two integer arrays "a" and "b". Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as their first element.
        start1([1, 2, 3], [1, 3]) → 2
        start1([7, 2, 3], [1]) → 1
        start1([1, 2], []) → 1
        */

        public int StartOne(int[] a, int[] b)
        {
            int firstElementOneCount = 0;

            if (a != null && a.Length > 0 && a[0] == 1)
            {
                firstElementOneCount++;
            }
            if (b != null && b.Length > 0 && b[0] == 1)
            {
                firstElementOneCount++;
            }
            return firstElementOneCount;
        }
    }
}

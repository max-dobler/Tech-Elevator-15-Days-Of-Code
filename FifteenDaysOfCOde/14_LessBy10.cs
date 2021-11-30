using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--11/7/2021--
        Days of Code: Day[14]
        Exercise 14: LessBy10
        Create a boolean method called LessBy10 that take in three integers, “a, “b”, and “c”. Given three ints, a b c, return true if one of them is 10 or more different than one of the others.
        lessBy10(1, 7, 11) → true
        lessBy10(1, 7, 10) → false
        lessBy10(11, 1, 7) → true
        */

        public bool LessByTen(int a, int b, int c)
        {
            int diffAB = Math.Abs(a - b);
            int diffAC = Math.Abs(a - c);
            int diffBC = Math.Abs(b - c);

            if (diffAB >= 10 || diffAC >= 10 || diffBC >= 10)
            {
                return true;
            }
            return false;
        }
    }
}

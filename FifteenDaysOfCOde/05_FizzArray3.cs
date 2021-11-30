using System;
using System.Collections.Generic;
using System.Text;

namespace FifteenDaysOfCode
{
    public partial class CodeExercises
    {
        /*--10/22/2021--
        Days of Code: Day[5]
        Exercise 5: FizzArray3
        Create an integer array method called FizzArray3  that takes in two integers "start" and "end"
        Given start and end numbers, return a new array containing the sequence of integers from start up to but  not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal  to the start number. Note that a length-0 array is valid. 
        fizzArray3(5, 10) → [5, 6, 7, 8, 9]
        fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
        fizzArray3(1, 3) → [1, 2]
        */

        public int[] FizzArrayThree(int start, int end)
        {
            //start <= end
            if (end - start == 0)
            {
                return new int[0];
            }
            else
            {
                int[] result = new int[end - start];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = start + i;
                }
                return result;
            }
        }
    }
}

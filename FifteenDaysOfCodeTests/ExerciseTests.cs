using Microsoft.VisualStudio.TestTools.UnitTesting;
using FifteenDaysOfCode;

namespace FifteenDaysOfCodeTests
{
    [TestClass]
    public class ExerciseTests
    {
        CodeExercises exercises = new CodeExercises();

        [TestMethod]
        public void SwapEndsTest()
        {
            CollectionAssert.AreEqual(new int[] { 4, 2, 3, 1 }, exercises.SwapEnds(new int[] { 1, 2, 3, 4 }), "Test 1: Input was [1, 2, 3, 4]");
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.SwapEnds(new int[] { 1, 2, 3 }), "Test 2: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 9, 8 }, exercises.SwapEnds(new int[] { 8, 6, 7, 9, 5 }), "Test 3: Input was [8, 6, 7, 9, 5]");
            CollectionAssert.AreEqual(new int[] { 0 }, exercises.SwapEnds(new int[] { 0 }), "Test 4: Input was [0]");
            CollectionAssert.AreEqual(new int[] { }, exercises.SwapEnds(new int[] { }), "Test 5: Input was null");
        }

        [TestMethod]
        public void HasTwelveTest()
        {
            Assert.AreEqual(true, exercises.HasTwelve(new int[] { 1, 3, 2 }), "Test 1: Input was [1, 3, 2]");
            Assert.AreEqual(true, exercises.HasTwelve(new int[] { 3, 1, 2 }), "Test 2: Input was [3, 1, 2]");
            Assert.AreEqual(true, exercises.HasTwelve(new int[] { 3, 1, 4, 5, 2 }), "Test 3: Input was [3, 1, 4, 5, 2]");
            Assert.AreEqual(false, exercises.HasTwelve(new int[] { 2, 1, 3 }), "Test 4: Input was [2, 1, 3]");
            Assert.AreEqual(false, exercises.HasTwelve(new int[] { 1 }), "Test 5: Input was [1]");
            Assert.AreEqual(false, exercises.HasTwelve(new int[] { }), "Test 6: Input was null");
        }
    }
}

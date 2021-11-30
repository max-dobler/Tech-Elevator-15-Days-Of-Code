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

        [TestMethod]
        public void GreenTicketTest()
        {
            Assert.AreEqual(0, exercises.GreenTicket(1, 2, 3), "Test 1: Input was (1, 2, 3)");
            Assert.AreEqual(20, exercises.GreenTicket(2, 2, 2), "Test 2: Input was (2, 2, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(1, 1, 2), "Test 3: Input was (1, 1, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(-1, 3, 3), "Test 4: Input was (-1, 3, 3)");
            Assert.AreEqual(20, exercises.GreenTicket(0, 0, 0), "Test 5: Input was (0, 0, 0)");
            Assert.AreEqual(0, exercises.GreenTicket(1, -6, 30), "Test 6: Input was (1, -6, 30)");

        }

        [TestMethod]
        public void StartOneTest()
        {
            Assert.AreEqual(2, exercises.StartOne(new int[] { 1, 2, 3}, new int[] {1, 3}), "Test 1: Input was ([1, 2, 3], [1, 3])");
            Assert.AreEqual(1, exercises.StartOne(new int[] { 7, 2, 3 }, new int[] { 1 }), "Test 2: Input was ([7, 2, 3], [1])");
            Assert.AreEqual(2, exercises.StartOne(new int[] { 1, 0 }, new int[] { 1 }), "Test 3: Input was ([1, 0], [1])");
            Assert.AreEqual(0, exercises.StartOne(new int[] { 5, 6, 7 }, new int[] { 3, 3 }), "Test 4: Input was ([5, 6, 7], [3, 3])");
            Assert.AreEqual(1, exercises.StartOne(new int[] { 1, 2, 3 }, new int[] { }), "Test 5: Input was ([1, 2, 3], [ ])");
            Assert.AreEqual(0, exercises.StartOne(new int[] { }, new int[] { }), "Test 6: Input was ([ ], [ ])");
        }

        [TestMethod]
        public void FizzArrayThree()
        {
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9 }, exercises.FizzArrayThree(5,10), "Test 1: Input was (5, 10)");
            CollectionAssert.AreEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }, exercises.FizzArrayThree(11,18), "Test 2: Input was (11, 18)");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.FizzArrayThree(1,3), "Test 3: Input was (1, 3)");
            CollectionAssert.AreEqual(new int[] { }, exercises.FizzArrayThree(2,2), "Test 4: Input was (2, 2)");
            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4 }, exercises.FizzArrayThree(0, 5), "Test 5: Input was (0, 5)");
            CollectionAssert.AreEqual(new int[] { -1, 0, 1, 2 }, exercises.FizzArrayThree(-1, 3), "Test 6: Input was (-1, 3)");
        }

        [TestMethod]
        public void OnlyOneFour()
        {
            Assert.AreEqual(true, exercises.OnlyOneFour(new int[] { 1, 4, 1, 4 }), "Test 1: Input was [1, 4, 1, 4]");
            Assert.AreEqual(false, exercises.OnlyOneFour(new int[] { 1, 4, 2, 4 }), "Test 2: Input was [1, 4, 2, 4]");
            Assert.AreEqual(false, exercises.OnlyOneFour(new int[] { -1, 1, 4, -4 }), "Test 3: Input was [-1, 1, 4, -4]");
            Assert.AreEqual(false, exercises.OnlyOneFour(new int[] { 0 }), "Test 4: Input was [0]");
            Assert.AreEqual(true, exercises.OnlyOneFour(new int[] { 1 }), "Test 5: Input was [1]");
            Assert.AreEqual(false, exercises.OnlyOneFour(new int[] { }), "Test 6: Input was null");
        }

        [TestMethod]
        public void NoTriples()
        {
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1, 2, 2, 1 }), "Test 1: Input was [1, 1, 2, 2, 1]");
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 2, 2, 2, 1 }), "Test 2: Input was [1, 1, 2, 2, 2, 1]");
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 }), "Test 3: Input was [1, 1, 1, 2, 2, 2, 1]");
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 0, -1, -1, -1, 0 }), "Test 4: Input was [0, -1, -1, -1, 0]");
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1 }), "Test 5: Input was [1]");
            Assert.AreEqual(true, exercises.NoTriples(new int[] { }), "Test 6: Input was null");
        }

        [TestMethod]
        public void NoTwoThree()
        {
            Assert.AreEqual(false, exercises.NoTwoThree(new int[] { 1, 2 }), "Test 1: Input was [1, 2]");
            Assert.AreEqual(true, exercises.NoTwoThree(new int[] { -2, 6 }), "Test 2: Input was [1, 2]");
            Assert.AreEqual(false, exercises.NoTwoThree(new int[] { 3, 0 }), "Test 3: Input was [1, 2]");
            Assert.AreEqual(true, exercises.NoTwoThree(new int[] { 0, 0 }), "Test 4: Input was [1, 2]");
            Assert.AreEqual(false, exercises.NoTwoThree(new int[] { 2, 2 }), "Test 5: Input was [1, 2]");
        }

        [TestMethod]
        public void NoOneFour()
        {
            Assert.AreEqual(true, exercises.NoOneFour(new int[] { 7, 2, 3 }), "Test 1: Input was [7, 2, 3]");
            Assert.AreEqual(false, exercises.NoOneFour(new int[] { 1, 2, 3, 4 }), "Test 2: Input was [1, 2, 3, 4]");
            Assert.AreEqual(false, exercises.NoOneFour(new int[] { 2, 3, 4 }), "Test 3: Input was [2, 3, 4]");
            Assert.AreEqual(true, exercises.NoOneFour(new int[] { 0, 0 }), "Test 4: Input was [0, 0]");
            Assert.AreEqual(true, exercises.NoOneFour(new int[] { }), "Test 5: Input was null");
        }

        [TestMethod]
        public void MoreOneFour()
        {
            Assert.AreEqual(true, exercises.MoreOneFour(new int[] { 1, 4, 1 }), "Test 1: Input was [1, 4, 1]");
            Assert.AreEqual(false, exercises.MoreOneFour(new int[] { 1, 4, 1, 4 }), "Test 2: Input was [1, 4, 1, 4]");
            Assert.AreEqual(true, exercises.MoreOneFour(new int[] { 1, 1 }), "Test 3: Input was [1, 1]");
            Assert.AreEqual(false, exercises.MoreOneFour(new int[] { 0, 0 }), "Test 4: Input was [0, 0]");
            Assert.AreEqual(false, exercises.MoreOneFour (new int[] { }), "Test 5: Input was null");
        }

        [TestMethod]
        public void MakeMiddle()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, exercises.MakeMiddle(new int[] { 1, 2, 3, 4 }), "Test 1: Input was [1, 2, 3, 4]");
            CollectionAssert.AreEqual(new int[] { 2, 3 }, exercises.MakeMiddle(new int[] { 7, 1, 2, 3, 4, 9 }), "Test 2: Input was [7, 1, 2, 3, 4, 9]");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.MakeMiddle(new int[] { 1, 2 }), "Test 3: Input was [1, 2]");
            CollectionAssert.AreEqual(new int[] { 0, 0 }, exercises.MakeMiddle(new int[] { 0, 0 }), "Test 4: Input was [0, 0]");
            CollectionAssert.AreEqual(new int[] { 0, 2 }, exercises.MakeMiddle(new int[] { -4, -2, 0, 2, 4, 6 }), "Test 5: Input was [-4, -2, 0, 2, 4, 6]");
        }

        [TestMethod]
        public void MakeLast()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 6 }, exercises.MakeLast(new int[] { 4, 5, 6 }), "Test 1: Input was [4, 5, 6]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2 }, exercises.MakeLast(new int[] { 1, 2 }), "Test 2: Input was [1, 2]");
            CollectionAssert.AreEqual(new int[] { 0, 3 }, exercises.MakeLast(new int[] { 3 }), "Test 3: Input was [3]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0 }, exercises.MakeLast(new int[] { 0, 0 }), "Test 4: Input was [0, 0]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9 }, exercises.MakeLast(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }), "Test 5: Input was [1, 2, 3, 4, 5, 6, 7, 8, 9]");
        }

        [TestMethod]
        public void MakeEnds()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3 }, exercises.MakeEnds(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 1, 4 }, exercises.MakeEnds(new int[] { 1, 2, 3, 4 }), "Test 2: Input was [1, 2, 3, 4]");
            CollectionAssert.AreEqual(new int[] { 7, 2 }, exercises.MakeEnds(new int[] { 7, 4, 6, 2 }), "Test 3: Input was [7, 4, 6, 2]");
            CollectionAssert.AreEqual(new int[] { 0, 0 }, exercises.MakeEnds(new int[] { 0 }), "Test 4: Input was [0]");
            CollectionAssert.AreEqual(new int[] { 1, 1 }, exercises.MakeEnds(new int[] { 1 }), "Test 5: Input was [1]");
        }

        [TestMethod]
        public void LessByTen()
        {
            Assert.AreEqual(true, exercises.LessByTen(1, 7, 11), "Test 1: Input was (1, 7, 11)");
            Assert.AreEqual(false, exercises.LessByTen(1, 7, 10), "Test 2: Input was (1, 7, 10)");
            Assert.AreEqual(true, exercises.LessByTen(11, 1, 7), "Test 3: Input was (11, 1, 7)");
            Assert.AreEqual(false, exercises.LessByTen(0, 0, 0), "Test 4: Input was (0, 0, 0)");
            Assert.AreEqual(true, exercises.LessByTen(-10, 10, 11), "Test 5: (-10, 10, 11)");
        }

        [TestMethod]
        public void HasTwoThree()
        {
            Assert.AreEqual(true, exercises.HasTwoThree(new int[] { 2, 5 }), "Test 1: Input was [2, 5]");
            Assert.AreEqual(true, exercises.HasTwoThree(new int[] { 4, 3 }), "Test 2: Input was [4, 3]");
            Assert.AreEqual(false, exercises.HasTwoThree(new int[] { 4, 5 }), "Test 3: Input was [4, 5]");
            Assert.AreEqual(false, exercises.HasTwoThree(new int[] { 0, 0 }), "Test 4: Input was [0, 0]");
            Assert.AreEqual(false, exercises.HasTwoThree(new int[] { -2, -3 }), "Test 5: Input was [-2, -3]");
        }
    }
}

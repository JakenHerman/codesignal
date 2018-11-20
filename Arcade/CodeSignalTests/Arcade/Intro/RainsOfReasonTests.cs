using Arcade.Intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSignalTests
{
    [TestClass()]
    public class RainsOfReasonTest
    {
        [TestMethod]
        public void TestArrayReplace()
        {
            int[] inputArray = new int[3] { 1, 2, 1 };
            int[] expectedArray = new int[3] { 3, 2, 3 };
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 1, 3));

            inputArray = new int[5] { 1, 2, 3, 4, 5 };
            expectedArray = new int[5] { 1, 2, 0, 4, 5 };
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 3, 0));

            inputArray = new int[3] { 1, 1, 1 };
            expectedArray = new int[3] { 10, 10, 10 };
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 1, 10));

            inputArray = new int[5] { 1, 2, 1, 2, 1 };
            expectedArray = new int[5] { 1, 1, 1, 1, 1 };
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 2, 1));

            inputArray = new int[5] { 1, 2, 1, 2, 1 };
            expectedArray = new int[5] { 1, 2, 1, 2, 1 };
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 2, 2));

            inputArray = new int[2] { 3, 1 };
            expectedArray = new int[2] {9, 1};
            CollectionAssert.AreEqual(expectedArray, RainsOfReason.ArrayReplace(inputArray, 3, 9));
        }
    }
}

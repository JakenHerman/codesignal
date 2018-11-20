using Arcade.Intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSignalTests
{
    [TestClass()]
    public class EdgeOfTheOceanTests
    {
        [TestMethod]
        public void TestArrayReplace()
        {
            int[] inputArray = new int[] { 3, 6, -2, -5, 7, 3 };
            Assert.AreEqual(21, EdgeOfTheOcean.AdjacentElementsProduct(inputArray));

            inputArray = new int[] { -1, -2 };
            Assert.AreEqual(2, EdgeOfTheOcean.AdjacentElementsProduct(inputArray));

            inputArray = new int[] { 5, 1, 2, 3, 1, 4 };
            Assert.AreEqual(6, EdgeOfTheOcean.AdjacentElementsProduct(inputArray));

            inputArray = new int[] { 5, 6, -4, 2, 3, 2, -23 };
            Assert.AreEqual(30, EdgeOfTheOcean.AdjacentElementsProduct(inputArray));
        }
    }
}

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
            Assert.AreEqual(21, EdgeOfTheOcean.AdjacentElementsProduct(new int[] { 3, 6, -2, -5, 7, 3 }));
            Assert.AreEqual(2, EdgeOfTheOcean.AdjacentElementsProduct(new int[] { -1, -2 }));
            Assert.AreEqual(6, EdgeOfTheOcean.AdjacentElementsProduct(new int[] { 5, 1, 2, 3, 1, 4 }));
            Assert.AreEqual(30, EdgeOfTheOcean.AdjacentElementsProduct(new int[] { 5, 6, -4, 2, 3, 2, -23 }));
        }

        [TestMethod]
        public void TestShapeArea()
        {
            Assert.AreEqual(5, EdgeOfTheOcean.ShapeArea(2));
            Assert.AreEqual(13, EdgeOfTheOcean.ShapeArea(3));
            Assert.AreEqual(1, EdgeOfTheOcean.ShapeArea(1));
            Assert.AreEqual(41, EdgeOfTheOcean.ShapeArea(5));
        }

        [TestMethod]
        public void TestMakeArrayConsecutive2()
        {
            Assert.AreEqual(3, EdgeOfTheOcean.MakeArrayConsecutive2(new int[]{6, 2, 3, 8}));
            Assert.AreEqual(2, EdgeOfTheOcean.MakeArrayConsecutive2(new int[]{0, 3}));
            Assert.AreEqual(0, EdgeOfTheOcean.MakeArrayConsecutive2(new int[]{ 5, 4, 6 }));
            Assert.AreEqual(0, EdgeOfTheOcean.MakeArrayConsecutive2(new int[]{ 1 }));
        }
    }
}

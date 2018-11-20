using SkillTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSignalTests
{
    [TestClass()]
    public class SkillTestTests
    {
        [TestMethod]
        public void TestIsLucky()
        {
            Assert.IsTrue(STMain.IsLucky(1230));
            Assert.IsFalse(STMain.IsLucky(239017));
            Assert.IsTrue(STMain.IsLucky(134008));
            Assert.IsFalse(STMain.IsLucky(10));
            Assert.IsTrue(STMain.IsLucky(11));
            Assert.IsTrue(STMain.IsLucky(1010));
            Assert.IsFalse(STMain.IsLucky(261534));
            Assert.IsFalse(STMain.IsLucky(100000));
            Assert.IsTrue(STMain.IsLucky(999999));
            Assert.IsTrue(STMain.IsLucky(123321));
        }
    }
}

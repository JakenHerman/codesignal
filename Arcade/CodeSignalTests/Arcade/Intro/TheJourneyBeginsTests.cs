using Arcade.Intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSignalTests
{
    [TestClass()]
    public class TheJourneyBeginsTests
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(3, TheJourneyBegins.Add(1, 2));
            Assert.AreEqual(1000, TheJourneyBegins.Add(0, 1000));
            Assert.AreEqual(1000, TheJourneyBegins.Add(0, 1000));
            Assert.AreEqual(-37, TheJourneyBegins.Add(2, -39));
            Assert.AreEqual(0, TheJourneyBegins.Add(-100, 100));
            Assert.AreEqual(-2000, TheJourneyBegins.Add(-1000, -1000)); 
        }

        [TestMethod]
        public void TestCenturyFromYear()
        {
            Assert.AreEqual(20, TheJourneyBegins.CenturyFromYear(1905));
            Assert.AreEqual(17, TheJourneyBegins.CenturyFromYear(1700));
            Assert.AreEqual(20, TheJourneyBegins.CenturyFromYear(1988));
            Assert.AreEqual(20, TheJourneyBegins.CenturyFromYear(2000));
            Assert.AreEqual(21, TheJourneyBegins.CenturyFromYear(2001));
            Assert.AreEqual(2, TheJourneyBegins.CenturyFromYear(200));
            Assert.AreEqual(4, TheJourneyBegins.CenturyFromYear(374));
            Assert.AreEqual(1, TheJourneyBegins.CenturyFromYear(45));
            Assert.AreEqual(1, TheJourneyBegins.CenturyFromYear(8));
        }

        [TestMethod]
        public void TestCheckPalindrome()
        {
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("aabaa"));
            Assert.IsFalse(TheJourneyBegins.CheckPalindrome("abac"));
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("a"));
            Assert.IsFalse(TheJourneyBegins.CheckPalindrome("az"));
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("abacaba"));
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("z"));
            Assert.IsFalse(TheJourneyBegins.CheckPalindrome("aaabaaaa"));
            Assert.IsFalse(TheJourneyBegins.CheckPalindrome("zzzazzazz"));
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("hlbeeykoqqqqokyeeblh"));
            Assert.IsTrue(TheJourneyBegins.CheckPalindrome("hlbeeykoqqqokyeeblh"));
        }
    }
}

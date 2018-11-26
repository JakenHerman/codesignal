using Arcade.Intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeSignalTests
{
    [TestClass()]
    public class SmoothSailingTests
    {
        [TestMethod]
        public void TestAllLongestStrings()
        {
            string[] expected = { "aba", "vcd", "aba" };
            string[] input = { "aba", "aa", "ad", "vcd", "aba" };
            CollectionAssert.AreEqual(expected, SmoothSailing.AllLongestStrings(input));

            expected = new string[] { "aa" };
            input = new string[] { "aa" };
            CollectionAssert.AreEqual(expected, SmoothSailing.AllLongestStrings(input));

            input = new string[] { "abc", "eeee", "abcd", "dcd" };
            expected = new string[] { "eeee", "abcd" };
            CollectionAssert.AreEqual(expected, SmoothSailing.AllLongestStrings(input));

            input = new string[] {"a","abc","cbd","zzzzzz","a","abcdef","asasa","aaaaaa"};
            expected = new string[] { "zzzzzz","abcdef","aaaaaa"};
            CollectionAssert.AreEqual(expected, SmoothSailing.AllLongestStrings(input));
        }
    }
}

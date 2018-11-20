﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.Medium;

namespace CodeSignalTests
{
    [TestClass()]
    public class ChallengeTests
    {
        [TestMethod]
        public void TestZigZag()
        {
            int[] a = new int[] { 9, 8, 8, 5, 3, 5, 3, 2, 8, 6 };
            Assert.AreEqual(4, ZigZag.Zigzag(a));

            int[] b = new int[] { 4, 4 };
            Assert.AreEqual(1, ZigZag.Zigzag(b));

            int[] c = new int[] { 2, 1, 4, 4, 1, 4, 4, 1, 2, 0, 1, 0, 0, 3, 1, 3, 4, 1, 3, 4 };
            Assert.AreEqual(6, ZigZag.Zigzag(c));
        }
    }
}

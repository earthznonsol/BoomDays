using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoomDays;

namespace BoomDaysTest
{
    [TestClass]
    public class BoomDaysTestMain
    {
        [TestMethod]
        public void TestGetBommSizeAndDay()
        {
            int expectedDays = 3;
            int expectedBommSize = 8000;

            Gossip gossip = new Gossip();

            int actualBoomSize = gossip.MaxBoomSize;
            int actualDay = gossip.Days;

            Assert.AreEqual(expectedBommSize, actualBoomSize);
            Assert.AreEqual(expectedDays, actualDay);
        }
    }
}

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

            int start_people = 1;
            Gossip gossip = new Gossip(start_people);
            gossip.CalculateBoomSize();

            int actualBoomSize = gossip.MaxBoomSize;
            int actualDay = gossip.Days;

            Assert.AreEqual(expectedBommSize, actualBoomSize);
            Assert.AreEqual(expectedDays, actualDay);
        }
    }
}

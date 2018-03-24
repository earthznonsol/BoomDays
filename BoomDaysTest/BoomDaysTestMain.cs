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
            Gossip gossip = new Gossip();

            int expectedBommSize = 400;
            int people = 20;

            int actualBoomSize = gossip.GetBoomSize(people);

            Assert.AreEqual(expectedBommSize, actualBoomSize);
        }
    }
}

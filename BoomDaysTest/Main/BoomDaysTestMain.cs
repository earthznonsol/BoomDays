using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoomDays.Main;

namespace BoomDaysTest.Main
{
    [TestClass]
    public class BoomDaysTestMain
    {
        [TestMethod]
        public void RetrieveResult()
        {
            
            int expectedDays = 3;
            int expectedBommSize = 8000;

            Gossip gossip = new Gossip();
            gossip.CalculateMaxBoomSize();


            int actualBoomSize = gossip.MaxBoomSize;
            int actualDay = gossip.Days;

            Assert.AreEqual(expectedBommSize, actualBoomSize);
            Assert.AreEqual(expectedDays, actualDay);
        }
    }
}

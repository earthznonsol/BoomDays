using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoomDays.Main;

namespace BoomDaysTest.Main
{
    [TestClass]
    public class BoomDaysTestMain
    {
        [TestMethod]
        public void CurrentBoomSize()
        {
            int expectedPeople = 20;
            int expectedBoomSize = 400;

            Gossip gossip = new Gossip();
            gossip.CurrBoomsize = expectedPeople;

            int actualBoomSize = gossip.CurrBoomsize;

            Assert.AreEqual(expectedBoomSize, actualBoomSize);
        }

        [TestMethod]
        public void StoreResult()
        {
            Gossip gossip = new Gossip();
            // Day1
            int expectedDay1 = 1;
            int expectedBoomSize1 = 20;

            gossip.CurrBoomsize = expectedBoomSize1;
            gossip.StoreResults();

            int actualDay1 = gossip.Days;
            int actualBoomSize1 = gossip.CurrBoomsize;

            Assert.AreEqual(expectedDay1, actualDay1);
            ///////////////////////////////////////////////

            // Day2
            int expectedDay2 = 2;
            int expectedBoomSize2 = 400;

            gossip.CurrBoomsize = expectedBoomSize2;
            gossip.StoreResults();

            int actualDay2 = gossip.Days;
            int actualBoomSize2 = gossip.CurrBoomsize;

            Assert.AreEqual(expectedDay2, actualDay2);
            ///////////////////////////////////////////////
        }

        [TestMethod]
        public void RetrieveResult()
        {
            
            int expectedDays = 3;
            int expectedBoomSize = 8000;

            Gossip gossip = new Gossip();
            gossip.CalculateMaxBoomSize();


            int actualBoomSize = gossip.MaxBoomSize;
            int actualDay = gossip.Days;

            Assert.AreEqual(expectedBoomSize, actualBoomSize);
            Assert.AreEqual(expectedDays, actualDay);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoomDays.Main;

namespace BoomDaysTest
{
    [TestClass]
    public class BoomDaysTestMain
    {
        [TestMethod]
        public void TestGetBommSizeAndDay()
        {
            BoomDays.Main.BoomDays boomDays = new BoomDays.Main.BoomDays();

            int expectedBommSize = 400;
            int people = 20;

            int actualBoomSize = boomDays.GetBoomSize(people);

            Assert.AreEqual(expectedBommSize, actualBoomSize);
        }
    }
}

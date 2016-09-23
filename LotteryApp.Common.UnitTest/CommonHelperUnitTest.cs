using System;
using LotteryApp.Common.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotteryApp.Common.UnitTest
{
    [TestClass]
    public class CommonHelperUnitTest
    {
        [TestMethod]
        public void GenerateLotteryNumbersTest()
        {
            var items = LotteryHelper.GenerateLotteryNumbers(6, 1, 49);
            Assert.AreEqual<int>(6, items.Count);
        }
    }
}

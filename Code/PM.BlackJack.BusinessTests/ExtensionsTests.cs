using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM.BlackJack.Business.Tests
{
    [TestClass()]
    public class ExtensionsTests
    {
        [TestMethod()]
        public void GetCardFaceValueForKingTest()
        {
            var result = CardFaceValue.King.GetCardValue();
            Assert.AreEqual(10, result);
        }

        [TestMethod()]
        public void GetCardFaceValueForSevenTest()
        {
            var result = CardFaceValue.Seven.GetCardValue();
            Assert.AreEqual(7, result);
        }
    }
}
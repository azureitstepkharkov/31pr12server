using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelperLib;

namespace MathHelperLibTest
{
    [TestClass]
    public class MathHelperLibUnitTest
    {
        [TestMethod]
        public void Subtract_20_10_returned_10()
        {
            int a = 20;
            int b = 10;
            int expected = 10;

            MathHelper mathHelper = new MathHelper();
            int result = mathHelper.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Add_20_10_returned_30()
        {
            int a = 20;
            int b = 10;
            int expected = 30;

            MathHelper mathHelper = new MathHelper();
            int result = mathHelper.Add(a, b);
            Assert.AreEqual(result, expected);
        }
    }
}

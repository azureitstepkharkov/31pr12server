using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Tests
{
    [TestClass()]
    public class MathsHelperTests
    {
        [TestMethod]
        public void Subtract_20_10_returned_10()
        {
            int a = 20;
            int b = 10;
            int expected = 10;

            MathsHelper mathHelper = new MathsHelper();
            int result = mathHelper.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Add_20_10_returned_30()
        {
            int a = 20;
            int b = 10;
            int expected = 30;

            MathsHelper mathHelper = new MathsHelper();
            int result = mathHelper.Add(a, b);
            Assert.AreEqual(result, expected);
        }
    }
}
using System;
using ClassLibraryAutoTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Subtract_20_and_10_10returned()
        {
            //1.настройки тестовых данных
            //2.действия по проверке - тестированию
            //3.сравнить результат
            //1
            int a = 20;
            int b = 10;
            int expected = 10;
            //2
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(a, b);
            //3
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Add_20_and_10_40expected_30returned_test_fail()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(40, result);
        }
    }
}

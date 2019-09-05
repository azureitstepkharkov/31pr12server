using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsHelper3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsHelper3.Tests
{
    [TestClass()]
    public class MathsHelper3Tests
    {
        [TestMethod()]
        public void SubtractTest()
        {
            //1.настройки тестовых данных
            //2.действия по проверке - тестированию
            //3.сравнить результат
            //1
            int a = 20;
            int b = 10;
            int expected = 10;
            //2
            MathsHelper3 helper = new MathsHelper3();
            int result = helper.Subtract(a, b);
            //3
            Assert.AreEqual(expected, result);
        }
    }
}
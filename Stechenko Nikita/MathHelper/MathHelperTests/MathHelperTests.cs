using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Tests {

    [TestClass()]
    public class MathHelperTests {

        [TestMethod]
        public void Subtract_20_and_10_10returned()
        {

            // 1. настройки тестовых данных
            // 2. действия по проверке - тестированию
            // 3. сравнить результат

            int a = 20;
            int b = 10;
            int expected = 10;

            MathHelper helper = new MathHelper();
            int result = helper.Subtract( a, b );

            Assert.AreEqual( expected, result );

        }

        [TestMethod]
        public void Add_20_and_10_40expected_30returned_test_fail() {

            MathHelper helper = new MathHelper();

            int res = helper.Add( 20, 10 );
            Assert.AreEqual( 30, res );

        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathHelpLib;


namespace MathHelperLibTests {

    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void Subtract_20_and_10_10returned(  ) {

            // 1. настройки тестовых данных
            // 2. действия по проверке - тестированию
            // 3. сравнить результат

            int a = 20;
            int b = 10;
            int expected = 10;

            MathHelpercs helper = new MathHelpercs();
            int result = helper.Subtract( a, b );

            Assert.AreEqual( expected, result );

        }

        [TestMethod]
        public void Add_20_and_10_40expected_30returned_test_fail() {

            MathHelpercs helper = new MathHelpercs();

            int res = helper.Add( 20, 10 );
            Assert.AreEqual( 40, res );

        }
    }
}
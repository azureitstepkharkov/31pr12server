using Microsoft.VisualStudio.TestTools.UnitTesting;
using QudraticEquationUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QudraticEquationUnitTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        StringBuilder log = new StringBuilder();
        [TestMethod()]
        public void CalcSolutionTest2_1_minus_7_14_NoReturned()
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double x1 = 0;
            double x2 = 0;
            string msg = String.Empty;

            bool result = false;
            log = new StringBuilder();

            Program.CalcSolutionTest2_1_minus_7_14_NoReturned(out A, out B, out C, out x1, out x2, out msg, out result, log);
            Assert.AreEqual<string>(msg, "Корней нет");
        }

        [TestMethod()]
        public void CalcSolutionTest1_1_minus_7_12_NoReturned()
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double x1 = 0;
            double x2 = 0;
            string msg = String.Empty;

            bool result;
            log = new StringBuilder();

            Program.CalcSolutionTest1_1_minus_7_12_NoReturned(out A, out B, out C, out x1, out x2, out msg, out result, log);
            Assert.AreEqual<string>(msg, "X1=4, X2=3");

        }

        [TestMethod()]
        public void CheckLogTest()
        {

            Program.CheckLog("Корней нетX1=4, X2=3", log);
        }
    }
}
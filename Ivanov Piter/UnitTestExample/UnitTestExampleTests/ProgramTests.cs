using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void calcSolutionTest2Test()
        {
            bool result = false;
            String msg = String.Empty;
            double X1;
            double X2;
            double A;
            double B;
            double C;
            StringBuilder log = new StringBuilder();
            Program.calcSolutionTest2(out result,
                out msg,
                out X1,
                out X2,
                out A,
                out B,
                out C,
                log);
            //Assert.AreEqual<bool>(msg.Contains("Корней нет"),true);
            Assert.AreEqual<int>(msg.CompareTo("X1=3, X2=4"), 0);
        }

        [TestMethod()]
        public void calcSolutionTest1Test()
        {
            bool result = false;
            String msg = String.Empty;
            double X1;
            double X2;
            double A;
            double B;
            double C;
            StringBuilder log;
            Program.calcSolutionTest1(out result, 
                out msg, 
                out X1, 
                out X2, 
                out A, 
                out B, 
                out C, 
                out log);
            //Assert.AreEqual<bool>(msg.Contains("Корней нет"),true);
            Assert.AreEqual<int>(msg.CompareTo("Корней нет."), 0);
            //"X1=3, X2=4"
        }
        [TestMethod()]
        public void CheckLogTest()
        {
            bool result = false;
            String msg = String.Empty;
            double X1;
            double X2;
            double A;
            double B;
            double C;
            StringBuilder log;
            Program.calcSolutionTest1(out result,
               out msg,
               out X1,
               out X2,
               out A,
               out B,
               out C,
               out log);
            Program.calcSolutionTest2(out result,
    out msg,
    out X1,
    out X2,
    out A,
    out B,
    out C,
    log);
            Assert.AreEqual<int>(log.ToString().CompareTo("Корней нет.X1=3, X2=4"), 0);
        }
    }
}
using Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void Sum_Success()
        {
            Calculation calculation = new Calculation();
            int arg1 = 10;
            int arg2 = 20;
            int result = calculation.Sum(arg1, arg2);
            Assert.AreEqual(30, result);
        }


        [TestMethod]
        public void Sum_Failure()
        {
            Calculation calculation = new Calculation();
            int arg1 = 10;
            int arg2 = 20;
            int result = calculation.Sum(arg1, arg2);
            Assert.AreNotEqual(35, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using current_caculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace current_caculator.Tests
{
    [TestClass]
    public class caculateTests
    {
        [TestMethod]
        public void Current1Test()
        {
            var I1 =  current_caculator.caculate.current1(81, 9, 9, 9, 9);
            Assert.IsTrue(Math.Abs(I1 - 15) < 0.0000001);
        }
        [TestMethod]
        public void current2Test()
        {
            var I2 = current_caculator.caculate.current2(1, 2, 3, 4, 5);
            Assert.IsTrue(Math.Abs(I2 - 0.66337386) < 0.0000001);
        }
    }
}
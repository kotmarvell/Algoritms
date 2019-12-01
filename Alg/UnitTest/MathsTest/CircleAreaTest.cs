using Alg.Maths.Area;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.MathsTest
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void CircleAreaForRTest()
        {
            double R = 2;
            double area = 4 * 3.14;

            var res = CircleArea.CircleAreaForR(R);
            Assert.IsTrue(area == res);
        }

        [TestMethod]
        public void CircleAreaForDTest()
        {
            double D = 4;
            double area = 4 * 3.14;

            var res = CircleArea.CircleAreaForD(D);
            Assert.IsTrue(area == res);
        }
    }
}

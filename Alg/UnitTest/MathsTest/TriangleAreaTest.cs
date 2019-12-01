using Alg.Maths.Area;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.MathsTest
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void AreaOnThreeSidesTest()
        {
            double sideA = 4;
            double sideB = 5;
            double sideC = 6;
            double area = 6;

            double res = TriangleArea.AreaOnThreeSides(sideA, sideB, sideC);
            Assert.IsTrue(res == area);
        }
    }
}

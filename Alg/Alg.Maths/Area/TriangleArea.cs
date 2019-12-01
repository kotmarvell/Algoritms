using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Maths.Area
{
    public static class TriangleArea
    { 
        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static double AreaOnThreeSides(double sideA, double sideB, double sideC)
        {
            double p2 = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p2 * (p2 - sideA) * (p2 - sideB) * (p2 - sideC));

            return area;
        }

        /// <summary>
        /// Площадь через высоту и сторону,
        /// на которую опирается высота
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="hight"></param>
        /// <returns></returns>
        public static double AreaThroughHeight(double sideA, double hight)
        {
            double area = 0.5 * hight * sideA;

            return area;
        }


    }
}

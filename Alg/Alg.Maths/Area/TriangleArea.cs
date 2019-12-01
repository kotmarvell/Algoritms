using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Maths.Area
{
    public class TriangleArea : BaseArea
    { 
        public TriangleArea()
        {
        }

        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public double AreaOnThreeSides(double sideA, double sideB, double sideC)
        {
            double p2 = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p2 * (p2 - sideA) * (p2 - sideB) * (p2 - sideC));

            return area;
        }


    }
}

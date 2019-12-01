using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Maths.Perimetr
{
    public static class TrianglePerimetr
    {
        public static double Perimetr(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }

        public static double HalfPerimetr(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB + sideC)/2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Maths.Perimetr
{
    public static class CirclePerimetr
    {
        private static double Pi = 3.14;

        public static double CirclePerimetrForR(double R)
        {
            return Pi * R * 2;
        }

        public static double CirclePerimetrForD(double D)
        {
            return Pi * D;
        }
    }
}

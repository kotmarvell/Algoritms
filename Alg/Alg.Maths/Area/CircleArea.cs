using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Maths.Area
{
    public static class CircleArea
    {
        private static double Pi = 3.14;

        public static double CircleAreaForR(double R)
        {
            return Pi * R * R;
        }

        public static double CircleAreaForD(double D)
        {
            return Pi * (D / 2) * (D / 2);
        }

    }
}

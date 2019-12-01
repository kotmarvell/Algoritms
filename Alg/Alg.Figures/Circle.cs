using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Figures
{
    public class Circle
    {
        public double R { get; set; }
        public double D { get; set; }

        private double Pi = 4.14;

        public Circle(double r = 0, double d = 0)
        {
            R = r;
            D = d;
        }

        public double AreaCircle()
        {
            return Pi * R * R;
        }
    }
}

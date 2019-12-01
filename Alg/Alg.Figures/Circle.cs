using Alg.Maths.Area;
using Alg.Maths.Perimetr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Figures
{
    public class Circle : Figure
    {
        public double R { get; set; }
        public double D { get; set; }

        private double Pi = 3.14;

        public Circle(double r = 0, double d = 0)
        {
            R = r;
            D = d;
        }

        /// <summary>
        /// Площадь круга по радиусу или диаметру
        /// в зависимости от того,
        /// что дано
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            if (D != 0)
                return CircleArea.CircleAreaForD(D);
            else
                return CircleArea.CircleAreaForR(R);
        }

        /// <summary>
        /// Периметр круга по радиусу или диаметру
        /// в зависимости от того,
        /// что дано
        /// </summary>
        /// <returns></returns>
        public double PerimetrCircle()
        {
            if (D != 0)
                return CirclePerimetr.CirclePerimetrForD(D);
            else
                return CirclePerimetr.CirclePerimetrForR(R);
        }
    }
}

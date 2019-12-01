using System;
namespace Alg.Figures
{
    public class Triangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public double height { get; set; }

        public Triangle(double a = 0, double b = 0, double c = 0, double h = 0)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            height = h;
        }

        public double GetTriangleArea()
        {
            double p2 = GetTriangleHalfPerimetr();
            double area = Math.Sqrt(p2 * (p2 - sideA) * (p2 - sideB) * (p2 - sideC));

            return area;
        }

        public double GetTrianglePerimetr()
        {
            return sideA + sideB + sideC;
        }

        public double GetTriangleHalfPerimetr()
        {
            return (sideA + sideB + sideC) / 2;
        }
    }
}

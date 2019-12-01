using Alg.Maths.Area;
using Alg.Maths.Perimetr;
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

        /// <summary>
        /// Если высота задана, то находим по высоте и заданной стороне
        /// Если высота не задана, то по трем сторонам
        /// </summary>
        /// <returns></returns>
        public double GetTriangleArea()
        {
            if (height != 0)
            {
                if (sideA != 0)
                    return TriangleArea.AreaThroughHeight(sideA, height);
                else if (sideB != 0)
                    return TriangleArea.AreaThroughHeight(sideB, height);
                else
                    return TriangleArea.AreaThroughHeight(sideC, height);
            }
            else
                return TriangleArea.AreaOnThreeSides(sideA, sideB, sideC);
            
        }

        public double GetTrianglePerimetr()
        {
            return TrianglePerimetr.Perimetr(sideA, sideB, sideC);
        }

        public double GetTriangleHalfPerimetr()
        {
            return TrianglePerimetr.HalfPerimetr(sideA, sideB, sideC);
        }
    }
}

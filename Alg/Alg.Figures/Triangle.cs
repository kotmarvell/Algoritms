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

        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            height = GetHeight();
        }

        public double GetHeight()
        {
            double area = TriangleArea.AreaOnThreeSides(sideA, sideB, sideC);
            double hight = area / (0.5 * sideA);

            return hight;
        }

        /// <summary>
        /// Если высота задана, то находим по высоте и заданной стороне
        /// Если высота не задана, то по трем сторонам
        /// </summary>
        /// <returns></returns>
        public double GetTriangleArea()
        {
            if (height != 0 && sideA != 0)
            {
                return TriangleArea.AreaThroughHeight(sideA, height);
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

        public bool IsEquilateralTriangle()
        {
            if(sideA == sideB && sideB == sideC && sideC != 0)
                return true;
            else
                return false;
        }

        public bool IsRightTriangle()
        {
            if (IsTrue(sideA, sideB, sideC) || IsTrue(sideB, sideC, sideA) || IsTrue(sideC, sideA, sideB))
                return true;
            else
                return 
                    false;
  
        }

        private bool IsTrue(double cathetA, double cathetB, double hypotenuse)
        {
            if ((cathetA * cathetA + cathetB * cathetB )== hypotenuse * hypotenuse)
                return true;
            else
                return false;
        }

    }
}

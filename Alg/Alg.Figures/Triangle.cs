using Alg.Maths.Area;
using Alg.Maths.Perimetr;
using System;
namespace Alg.Figures
{
    public class Triangle : Figure
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
            double hight = area / (0.5 * sideB);

            return hight;
        }

        /// <summary>
        /// Площадь по трем сторонам
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return TriangleArea.AreaOnThreeSides(sideA, sideB, sideC);          
        }

        public double GetTrianglePerimetr()
        {
            return TrianglePerimetr.Perimetr(sideA, sideB, sideC);
        }


        /// <summary>
        /// Нахождение полупериметра
        /// </summary>
        /// <returns></returns>
        public double GetTriangleHalfPerimetr()
        {
            return TrianglePerimetr.HalfPerimetr(sideA, sideB, sideC);
        }

        /// <summary>
        /// Является ли треугольник правильным
        /// </summary>
        /// <returns></returns>
        public bool IsEquilateralTriangle()
        {
            if(sideA == sideB && sideB == sideC && sideC != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Провеска треугольника на наличие прямого угла
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (IsTrue(sideA, sideB, sideC) || IsTrue(sideB, sideC, sideA) || IsTrue(sideC, sideA, sideB))
                return true;
            else
                return 
                    false;
  
        }

        /// <summary>
        /// Проверка на правильность теоремы
        /// </summary>
        /// <param name="cathetA"></param>
        /// <param name="cathetB"></param>
        /// <param name="hypotenuse"></param>
        /// <returns></returns>
        private bool IsTrue(double cathetA, double cathetB, double hypotenuse)
        {
            if ((cathetA * cathetA + cathetB * cathetB ) == hypotenuse * hypotenuse)
                return true;
            else
                return false;
        }

    }
}

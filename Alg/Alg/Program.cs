using System;
using Alg.Figures;

namespace Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle
            {
                sideA = 8.0,
                sideB = 8.0,
                sideC = 8.0
            };

            double area = myTriangle.GetArea();
            Console.WriteLine(area + " ");

            Figure figure = myTriangle;
            Console.WriteLine(figure.GetArea());

        }
    }
}

using System;

namespace ProgrammingBasics.Domain.FirstMeet
{
    public class TasksOfTheSemester
    {
        /// <summary>
        /// Как поменять местами значения двух переменных?
        /// Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
        /// </summary>
        public (uint X, uint Y) SwapNaturalNumbersWithoutTmp(uint x, uint y)
        {
            /*
             * Это возможно.
             * Так делать не стоит - код усложняется, его становится труднее "читать", а затем и поддерживать.
            */

            checked
            {
                x += y;
                y = x - y;
                x = x - y;
            }

            return (x, y);
        }

        /// <summary>
        /// Посчитать расстояние от точки до прямой, заданной двумя разными точками.
        /// </summary>
        public double CalcPathFormPointToLine((int x, int y) point, (int x, int y) pointA, (int x, int y) pointB)
        {
            /*
             * 1. Найти уравнение прямой по двум точкам.
             * A*x+By+C
             * A = y1-y2
             * B = x2-x1
             * C = x1*y2-y1*x2
             * 
             * 2. Рссчитать расстояние от точки до прямой по формуле.
             * d = |Ax+Bx+C|/sqrt(A^2+B^2)
            */

            int a = pointA.y - pointB.y;
            int b = pointB.x - pointA.x;
            int c = pointA.x * pointB.y - pointA.y * pointB.x;

            return Math.Abs(a * point.x + b * point.y + c) / Math.Sqrt(a * a + b * b);
        }
    }
}

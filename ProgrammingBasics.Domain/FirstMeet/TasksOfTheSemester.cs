using System;

namespace ProgrammingBasics.Domain.FirstMeet
{
    public class TasksOfTheSemester
    {
        /// <summary>
        /// Как поменять местами значения двух переменных?
        /// Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>(Первое число, Второе число)</returns>
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
        /// Найти количество чисел меньших N, которые имеют простые делители X или Y.
        /// </summary>
        /// <param name="n">N.</param>
        /// <param name="x">Простое X.</param>
        /// <param name="y">Простое Y.</param>
        /// <returns>Количество чисел.</returns>
        public int GetCountNumbersLessN(int n, int x, int y)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (i % x == 0 && i % y == 0)
                    count++;

            return count;
        }

        /// <summary>
        /// Найти количество високосных лет на отрезке [a, b] не используя циклы.
        /// (по Григорианскому календарю)
        /// </summary>
        /// <returns>Количество високосных лет.</returns>
        public int CountLeapYears(int from, int to)
        {
            int fromCount = from / 400 - from / 100 + from / 4;
            int toCount = to / 400 - to / 100 + to / 4;

            return toCount - fromCount;
        }

        /// <summary>
        /// Посчитать расстояние от точки до прямой, заданной двумя разными точками.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <param name="pointA">Одна из точек прямой.</param>
        /// <param name="pointB">Одна из точек прямой.</param>
        /// <returns>Расстояние от точки до прямой.</returns>
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

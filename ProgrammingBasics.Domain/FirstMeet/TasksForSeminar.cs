using System;

namespace ProgrammingBasics.Domain.FirstMeet
{
    public class TasksForSeminar
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
        /// Задается натуральное трехзначное число (гарантируется, что трехзначное).
        /// Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        /// </summary>
        /// <param name="number">Трехзначаное число</param>
        /// <returns>Трехзначное число в обратном порядке.</returns>
        public int RevertNumber(int number)
        {
            var first = number / 100;
            var middle = (number - first * 100)/10;
            var last = number % 10;

            return last * 100 + middle * 10 + first;
        }

        /// <summary>
        /// Вычислить угол в градусах между часовой и минутной стрелками. Не использовать циклы.
        /// </summary>
        /// <param name="h">Время h часов.</param>
        /// <returns>Угол.</returns>
        public int GetAngelBetweenHourAndMinuteHand(int h)
        {
            var angel = (h % 12) * 30;
            return angel <= 180 ? angel : 360 - angel;
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
            for (int i = 1; i < n; i++)
                if (i % x == 0 || i % y == 0)
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

        /// <summary>
        /// Дана прямая L и точка A.
        /// Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A.
        /// Прямая задана двумя точками.
        /// </summary>
        /// <param name="point">Точка.</param>
        /// <param name="pointA">Одна из точек прямой.</param>
        /// <param name="pointB">Одна из точек прямой.</param>
        /// <returns>Точка пересечения.</returns>
        public (double x, double y) GetIntersectionPoint((int x, int y) point, (int x, int y) pointA, (int x, int y) pointB)
        {
            /*
             * 1. Найти уравнение прямой по двум точкам.
             * A*x+By+C
             * A = y1-y2
             * B = x2-x1
             * C = x1*y2-y1*x2
             * 
             * 2. Компоненты нормального для прямой вектора = (A, B)
             * Этот вектор также является направляющим для прямой перпендикулярной данной.
             * Зная это и координаты точки лежащей на прямой, для которой этот вектор является
             * направляющим, можно выразить компоненты A1, B1 и C1 уравнения этой прямой.
             * (x-px)/A = (y-py)/B => B*x+(-A)*y+(A*py-B*px)=0
             * A1 = B
             * B1 = -A
             * C1 = A*py-B*px
             * 
             * 3. Решить СЛАУ
             * Решение - точка пересечения прямых.
            */

            int a = pointA.y - pointB.y;
            int b = pointB.x - pointA.x;
            int c = pointA.x * pointB.y - pointA.y * pointB.x;

            int a1 = b;
            int b1 = -a;
            int c1 = a * point.y - b * point.x;

            double x = 0;
            double y = 0;

            if (a == 0)
            {
                y = -c / b;
                x = -c1 / a1;
            }
            else if (b == 0)
            {
                x = -c / a;
                y = -c1 / b1;
            }
            else
            {
                y = (a1 * c - a * c1) / (a * b1 - a1 * b);
                x = (-b * y - c) / a;
            }

            return (x, y);
        }
    }
}

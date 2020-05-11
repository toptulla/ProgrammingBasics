using System;

namespace ProgrammingBasics.Domain.Errors
{
    public class TasksForSeminar
    {
        /// <summary>
        /// Найти сумму всех положительных чисел меньше number кратных 3 или 5.
        /// </summary>
        /// <param name="number">Число, сумму которого необходимо найти.</param>
        /// <returns>Сумма чисел.</returns>
        public int SumNumbersMultiplesFiveAndThree(int number)
        {
            /*
             * Сумма чисел делящихся на какое-либо число - это сумма арифметической прогрессии.
             * Sn = ((2*a1+d*(n-1))/2)*n
             * d = a2-a1 - разность прогрессии.
             * n = количество членов последовательности.
             * 
             * Чтобы посчитать сумму чисел делящихся на 3 и на 5, необходимо
             * найти суммы арифметических прогрессий для 3 и 5, в обеих суммах
             * будут учавствовать числа, которые делятся на 3 и на 5 одновременно,
             * по этому нужно один раз вычесть сумму таких чисел.
            */

            var n3 = number / 3;
            var s3 = ((2 * 3 + 3 * (n3 - 1)) / 2) * n3;

            var n5 = number / 5;
            var s5 = ((2 * 5 + 5 * (n5 - 1)) / 2) * n5;

            // Если число делится на A и на B, то оно делится на A*B
            var n15 = number / 15;
            var s15 = ((2 * 15 + 15 * (n15 - 1)) / 2) * n15;

            return s3 + s5 - s15;
        }

        /// <summary>
        /// Вычислить угол в градусах между часовой и минутной стрелками. Не использовать циклы.
        /// </summary>
        /// <param name="hourCount">Время - часов.</param>
        /// <param name="minCount">Время - минут.</param>
        /// <returns>Угол.</returns>
        public double GetAngelBetweenHourAndMinuteHand(int hourCount, int minCount)
        {
            // Одна минута на часах - это 6 градусов
            double mAngel12 = minCount * 6;

            // Сдвиг на одну минуту часовой стрелки - это 1/2 градуса
            double hAngel12 = (hourCount % 12) * 30 + minCount * 1 / 2;

            var result = Math.Abs(mAngel12 - hAngel12);

            return result <= 180 ? result : 360 - result;
        }

        /// <summary>
        /// Самолёт должен набрать высоту h метров в течение первых t секунд полёта и удерживать
        /// её в течение всего полёта. Разрешён набор высоты со скоростью не более чем v метров в
        /// секунду. До полного набора высоты запрещено снижаться. Известно, что уши заложены в
        /// те и только те моменты времени, когда самолёт поднимается со скоростью более x метров
        /// в секунду. Посчитайте минимальное и максимальное возможное время, в течение которого
        /// у пассажиров будут заложены уши. Считайте, что самолёт способен изменять скорость
        /// мгновенно.
        /// </summary>
        /// <param name="h">Высота (в метрах).</param>
        /// <param name="t">Время (в секундах).</param>
        /// <param name="v">Максимальная скорость набора высоты (м/с).</param>
        /// <param name="x">Скорость после которой закладывает уши (м/с).</param>
        /// <returns>Минимальное и максимальное время заложенности ушей :)</returns>
        public (double minT, double maxT) MinMaxT(int h, int t, int v, int x)
        {
            double tmin = (h - x * t) / (v - x);
            return (tmin, t);
        }

        /// <summary>
        /// Козла пустили в квадратный огород и привязали к колышку. Колышек
        /// воткнули точно в центре огорода. Козёл ест всё, до чего дотянется,
        /// не перелезая через забор огорода и не разрывая веревку. Какая площадь
        /// огорода будет объедена? Даны длина веревки и размеры огорода.
        /// </summary>
        /// <param name="a">Сторона квадрата.</param>
        /// <param name="r">Радиус окружности.</param>
        /// <returns>Площадь пересечения квадрата и окружности</returns>
        public double GetCircleSquareIntersectionArea(double a, double r)
        {
            // Окружность вписана в квадрат
            if (r <= a / 2)
                return Math.Round(Math.PI * r * r, 3, MidpointRounding.ToZero);

            // Окружность описана вокруг квадрата
            if (r >= Math.Sqrt(2) * a / 2)
                return Math.Round(a * a, 3, MidpointRounding.ToZero);

            // Угол, на который опирается хорда.
            double q = 2 * Math.Acos(a / (2 * r));

            // Площадь сегмента окружности, выходящего за пределы квадрата
            double sSeg = 0.5 * r * r * (q - Math.Sin(q));

            // Площадь окружности - площадь 4-х сегментов
            return Math.Round(Math.PI * r * r - 4 * sSeg, 3, MidpointRounding.ToZero);
        }
    }
}

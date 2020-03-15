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
    }
}

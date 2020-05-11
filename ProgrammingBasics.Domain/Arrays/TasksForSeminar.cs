using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingBasics.Domain.Arrays
{
    public class TasksForSeminar
    {
        /// <summary>
        /// Дан массив чисел. Нужно его сдвинуть циклически на K позиций вправо, не используя других массивов.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <param name="shiftSize">Сдвиг.</param>
        /// <returns>Сдвинутый массив.</returns>
        public int[] ShiftArray(int[] arr, int shiftSize)
        {
            var shiftedArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + shiftSize < arr.Length)
                    shiftedArr[i + shiftSize] = arr[i];
                else
                    shiftedArr[(i + shiftSize) % arr.Length] = arr[i];
            }

            return shiftedArr;
        }

        /// <summary>
        /// Перевести число из системы счисления с основанием A в систему с основанием B. Можно считать, что 2 ≤ A, B ≤ 10, а число дано в виде массива цифр.
        /// </summary>
        /// <param name="a">Основание системы счисления из которой переводится число.</param>
        /// <param name="b">Основание системы счисления в которую переводится число.</param>
        /// <param name="number">Числов в виде массива цифр.</param>
        /// <returns>Число, получившееся в результатае перевода.</returns>
        public int[] FromSystemToSystem(int a, int b, int[] number)
        {
            /*
             *  Формула перевода в 10-ю систему счисления:
             *  A = a(n)*p^n + a(n-1)*p^n-1 + ... + a(0)*p^0
             *  
             *  Для перевода из 10-й системы в любую другую
             *  необходимо определять результат целочисленного деления
             *  и остаток от деления до тех пор, пока результат деления
             *  не будет равен 0. Получившаяся в результате нахождения
             *  остатка от деления последовательность чисел - это искомое
             *  число (от младших разрядов к старшим).
            */

            // Переводим в 10-ю
            int in10 = 0;
            for (int i = 0; i < number.Length; i++)
                in10 += number[i] * (int)Math.Pow(a, number.Length - i - 1);

            if (b == 10)
            {
                return in10.ToString()
                    .Select(ch => int.Parse(ch.ToString()))
                    .ToArray();
            }

            // Переводим в систему b
            var sb = new StringBuilder();
            int devideResult = in10;
            while (devideResult > 0)
            {
                sb.Append((devideResult % b).ToString());
                devideResult = devideResult / b;
            }

            return sb.ToString()
                .Reverse()
                .Select(ch => int.Parse(ch.ToString()))
                .ToArray();
        }

        /// <summary>
        /// Даны два неубывающих массива чисел. Сформировать неубывающие массивы,
        /// являющиеся объединением, пересечением и разностью этих двух массивов
        /// (разность в смысле мультимножеств).
        /// </summary>
        /// <param name="arrA">Массив первого множества.</param>
        /// <param name="arrB">Массив второго множества.</param>
        /// <returns>Объединение/Пересечение/Разность</returns>
        public (int[] Union, int[] Intersection, int[] Difference) GetUnionIntersectionDifference(int[] arrA, int[] arrB)
        {
            var union = arrA
                .Union(arrB)
                .ToArray();
            Array.Sort(union);

            var intersection = arrA
                .Intersect(arrB)
                .ToArray();
            Array.Sort(intersection);

            var difference = arrA
                .Except(arrB)
                .ToArray();
            Array.Sort(difference);

            return (union, intersection, difference);
        }

        /// <summary>
        /// * Дан неубывающий массив положительных целых чисел. Найти наименьшее положительное
        /// целое число, не представимое в виде суммы элементов этого массива (каждый элемент
        /// разрешается использовать в сумме только один раз).
        /// </summary>
        /// <param name="numbers">Неубывающий массив положительных целых чисел.</param>
        /// <returns>Наименьшее положительное целое число, не представимое в виде суммы элементов массива</returns>
        public int GetSmallestNumber(int[] numbers)
        {
            /*
             * До тех пор, пока элементы массива <= sum + 1, их можно представить суммой
             * предыдущих элементов.
             * Сдвигаем границу, пока цепочка не прервется.
            */
            int border = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= border + 1)
                    border += numbers[i];
                else
                    break;
            }
            return border + 1;
        }
    }
}

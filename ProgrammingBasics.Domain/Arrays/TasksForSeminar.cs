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

            // Переводим в b
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
    }
}

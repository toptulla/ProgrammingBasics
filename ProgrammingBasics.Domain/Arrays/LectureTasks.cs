using System;
using System.Linq;

namespace ProgrammingBasics.Domain.Arrays
{
    public class LectureTasks
    {
        /// <summary>
        /// Метод поиска минимума в массиве.
        /// </summary>
        /// <param name="array">Массим.</param>
        /// <returns>Значение минимального элемента.</returns>
        public double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min) min = item;
            return min;
        }

        /// <summary>
        /// Метод возвращает индекс максимального элемента в массиве.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <returns>Индекс максимального элемента.</returns>
        public int GetIndexOfMaxElement(double[] array)
        {
            if (!array.Any())
                return -1;

            return Array.IndexOf(array, array.Max());
        }

        /// <summary>
        /// Количество вхождений элемента в массив.
        /// </summary>
        /// <param name="items">Массив элементов.</param>
        /// <param name="itemToCount">Искомый элемент.</param>
        /// <returns>Количество.</returns>
        public int GetElementCount(int[] items, int itemToCount)
        {
            return items.Count(x => x == itemToCount);
        }

        /// <summary>
        /// Поиск начального индекса подмассива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="subArray">Искомый подмассив.</param>
        /// <returns>Начальный индекс в массиве, с которого начинается подмассив.</returns>
        public int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        /// <summary>
        /// Проверка, сорержится ли подмассив в массиве, начиная с указанного индекса.
        /// </summary>
        /// <param name="array">Массив, в котором ведется поиск подмассива.</param>
        /// <param name="subArray">Подмассив.</param>
        /// <param name="i">Индекс, начиная с которого, как предполагается, начинается подмассив.</param>
        /// <returns>Содержится/Не содержится.</returns>
        private bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            for (int j = i, k = 0; j < array.Length && k < subArray.Length; j++, k++)
            {
                if (array[j] != subArray[k])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Руссификация.
        /// </summary>
        /// <param name="suit">Масть карты.</param>
        /// <returns>Русское название масти.</returns>
        public string GetSuit(Suits suit)
            => suit switch
            {
                Suits.Wands => "жезлов",
                Suits.Coins => "монет",
                Suits.Cups => "кубков",
                Suits.Swords => "мечей",
                _ => throw new ArgumentException(nameof(suit))
            };

        /// <summary>
        /// Крестики-нолики
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <returns>Результат игры.</returns>
        public GameResult GetGameResult(Mark[,] field)
        {
            bool circleCheck = CheckMarkToWin(field, Mark.Circle);
            bool crossCheck = CheckMarkToWin(field, Mark.Cross);

            if (circleCheck && crossCheck)
                return GameResult.Draw;

            if (circleCheck)
                return GameResult.CircleWin;

            if (crossCheck)
                return GameResult.CrossWin;

            return GameResult.Draw;
        }

        /// <summary>
        /// Проверка значения (крестик/нолик) на выигрыш.
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <param name="mark">Проверяемое на выигрыш значение (крестик/нолик).</param>
        /// <returns>Выигрыш/нет выигрыша.</returns>
        private bool CheckMarkToWin(Mark[,] field, Mark mark)
        {
            for (int i = 0; i < field.GetLength(0); i++)
                if (CheckRow(field, mark, i))
                    return true;

            for (int i = 0; i < field.GetLength(1); i++)
                if (CheckColumn(field, mark, i))
                    return true;

            return CheckLeftToRightDiagonal(field, mark) || CheckRightToLeftDiagonal(field, mark);
        }

        /// <summary>
        /// Проверка выигрышного результата в строке.
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <param name="mark">Проверяемое на выигрыш значение (крестик/нолик).</param>
        /// <param name="rowIndex">Индекс строки в поле.</param>
        /// <returns>Выигрыш/нет выигрыша.</returns>
        private bool CheckRow(Mark[,] field, Mark mark, int rowIndex)
        {
            for (int i = 0; i < field.GetLength(1); i++)
                if (field[rowIndex, i] != mark)
                    return false;

            return true;
        }

        /// <summary>
        /// Проверка выигрышного результата в столбце.
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <param name="mark">Проверяемое на выигрыш значение (крестик/нолик).</param>
        /// <param name="colIndex">Индекс столбца в поле.</param>
        /// <returns>Выигрыш/нет выигрыша.</returns>
        private bool CheckColumn(Mark[,] field, Mark mark, int colIndex)
        {
            for (int i = 0; i < field.GetLength(0); i++)
                if (field[i, colIndex] != mark)
                    return false;

            return true;
        }

        /// <summary>
        /// Проверка выигрышного результата в диагонали слева - на право.
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <param name="mark">Проверяемое на выигрыш значение (крестик/нолик).</param>
        /// <returns>Выигрыш/нет выигрыша.</returns>
        private bool CheckLeftToRightDiagonal(Mark[,] field, Mark mark)
        {
            for (int i = 0, j = 0; i < field.GetLength(0) && j < field.GetLength(1); i++, j++)
                if (field[i, j] != mark)
                    return false;

            return true;
        }

        /// <summary>
        /// Проверка выигрышного результата в диагонали справа - на лево.
        /// </summary>
        /// <param name="field">Поле игры.</param>
        /// <param name="mark">Проверяемое на выигрыш значение (крестик/нолик).</param>
        /// <returns>Выигрыш/нет выигрыша.</returns>
        private bool CheckRightToLeftDiagonal(Mark[,] field, Mark mark)
        {
            for (int i = 0, j = field.GetLength(1) - 1; i < field.GetLength(0) && j > -1; i++, j--)
                if (field[i, j] != mark)
                    return false;

            return true;
        }
    }

    /// <summary>
    /// Масти карт.
    /// </summary>
    public enum Suits
    {
        Wands,
        Coins,
        Cups,
        Swords
    }

    /// <summary>
    /// Значения поля (не занято/крестик/нолик).
    /// </summary>
    public enum Mark
    {
        Empty,
        Cross,
        Circle
    }

    /// <summary>
    /// Результат игры в крестики-нолики.
    /// </summary>
    public enum GameResult
    {
        CrossWin,
        CircleWin,
        Draw
    }

}

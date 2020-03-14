namespace ProgrammingBasics.Domain.Errors
{
    public class LectureTasks
    {
        /// <summary>
        /// Определить минимум функции ax^2 + bx + c, а если его не существует,
        /// то вернуть "Impossible".
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <returns>Строковое представление min функции или "Impossible"/"Any"</returns>
        public string GetMinX(int a, int b, int c)
        {
            if (a == 0 && b == 0)
                return "Any";

            if (a <= 0)
                return "Impossible";

            double x = -1 * (double)b / (2 * a);

            return x.ToString();
        }
    }
}

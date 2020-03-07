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
    }
}

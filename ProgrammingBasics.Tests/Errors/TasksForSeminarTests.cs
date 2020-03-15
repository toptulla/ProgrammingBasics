using ProgrammingBasics.Domain.Errors;
using Xunit;

namespace ProgrammingBasics.Tests.Errors
{
    public class TasksForSeminarTests
    {
        #region Task 1
        [Fact]
        public void SumNumbersMultiplesFiveAndThreeSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.SumNumbersMultiplesFiveAndThree(15);

            Assert.Equal(60, result);
        }
        #endregion

        #region Task 2
        [Fact]
        public void GetAngelBetweenHourAndMinuteHandSimpleTest15_30()
        {
            var task = new TasksForSeminar();

            var result = task.GetAngelBetweenHourAndMinuteHand(15, 30);

            Assert.Equal<double>(75, result);
        }

        [Fact]
        public void GetAngelBetweenHourAndMinuteHandSimpleTest19_00()
        {
            var task = new TasksForSeminar();

            var result = task.GetAngelBetweenHourAndMinuteHand(19, 0);

            Assert.Equal<double>(150, result);
        }
        #endregion
    }
}

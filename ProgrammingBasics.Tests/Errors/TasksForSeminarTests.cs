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

        #region Task 3
        [Theory]
        [InlineData(10000, 500, 50, 10, 125, 500)]
        public void MinMaxTSimpleTest(int h, int t, int v, int x, double tmin, double tmax)
        {
            var task = new TasksForSeminar();

            var result = task.MinMaxT(h, t, v, x);

            Assert.Equal(tmin, result.minT);
            Assert.Equal(tmax, result.maxT);
        }
        #endregion

        #region Task 4
        [Theory]
        [InlineData(10, 6, 95.091)]
        [InlineData(10, 5, 78.539)]
        [InlineData(10, 10, 100)]
        public void GetCircleSquareIntersectionAreaSimpleTest(double a, double r, double expectedArea)
        {
            var task = new TasksForSeminar();

            var actualArea = task.GetCircleSquareIntersectionArea(a, r);

            Assert.Equal<double>(expectedArea, actualArea);
        }
        #endregion
    }
}

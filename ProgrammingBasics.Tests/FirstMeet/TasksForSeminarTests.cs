using ProgrammingBasics.Domain.FirstMeet;
using System;
using Xunit;

namespace ProgrammingBasics.Tests.FirstMeet
{
    public class TasksForSeminarTests
    {
        #region Task 1
        [Fact]
        public void SwapNaturalNumbersWithoutTmpSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.SwapNaturalNumbersWithoutTmp(x: 10, y: 20);

            Assert.Equal<uint>(20, result.X);
            Assert.Equal<uint>(10, result.Y);
        }

        [Fact]
        public void SwapNaturalNumbersWithoutTmpMaxIntTest()
        {
            var task = new TasksForSeminar();

            Assert.Throws<OverflowException>(() => task.SwapNaturalNumbersWithoutTmp(x: uint.MaxValue, y: 20));
        }
        #endregion

        #region Task 2
        [Fact]
        public void RevertNumberSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.RevertNumber(123);

            Assert.Equal<int>(321, result);
        }
        #endregion

        #region Task 3
        [Fact]
        public void GetAngelBetweenHourAndMinuteHandSimpleTest15()
        {
            var task = new TasksForSeminar();

            var result = task.GetAngelBetweenHourAndMinuteHand(15);

            Assert.Equal<int>(90, result);
        }

        [Fact]
        public void GetAngelBetweenHourAndMinuteHandSimpleTest9()
        {
            var task = new TasksForSeminar();

            var result = task.GetAngelBetweenHourAndMinuteHand(9);

            Assert.Equal<int>(90, result);
        }

        [Fact]
        public void GetAngelBetweenHourAndMinuteHandSimpleTest0()
        {
            var task = new TasksForSeminar();

            var result = task.GetAngelBetweenHourAndMinuteHand(20);

            Assert.Equal<int>(120, result);
        }
        #endregion

        #region Task 4
        [Fact]
        public void GetCountNumbersLessNSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.GetCountNumbersLessN(16, 3, 5);

            Assert.Equal<int>(7, result);
        }
        #endregion

        #region Task 5
        [Fact]
        public void CountLeapYearsSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.CountLeapYears(2019, 2021);

            Assert.Equal<int>(1, result);
        }
        #endregion

        #region Task 6
        [Fact]
        public void CalcPathFormPointToLineSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.CalcPathFormPointToLine((2, 2), (1, 1), (3, 1));

            Assert.Equal<double>(1, result);
        }
        #endregion

        #region Task 8
        [Fact]
        public void GetIntersectionPointSimpleTest0()
        {
            var task = new TasksForSeminar();

            var result = task.GetIntersectionPoint((2, 2), (0, 2), (2, 0));

            Assert.Equal<double>(1, result.x);
            Assert.Equal<double>(1, result.y);
        }

        [Fact]
        public void GetIntersectionPointSimpleTest1()
        {
            var task = new TasksForSeminar();

            var result = task.GetIntersectionPoint((2, 2), (1, 1), (3, 1));

            Assert.Equal<double>(2, result.x);
            Assert.Equal<double>(1, result.y);
        }
        #endregion
    }
}

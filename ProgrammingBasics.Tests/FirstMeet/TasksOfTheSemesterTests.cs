using ProgrammingBasics.Domain.FirstMeet;
using System;
using Xunit;

namespace ProgrammingBasics.Tests.FirstMeet
{
    public class TasksOfTheSemesterTests
    {
        #region Task 1
        [Fact]
        public void SwapNaturalNumbersWithoutTmpSimpleTest()
        {
            var task = new TasksOfTheSemester();

            var result = task.SwapNaturalNumbersWithoutTmp(x: 10, y: 20);

            Assert.Equal<uint>(20, result.X);
            Assert.Equal<uint>(10, result.Y);
        }

        [Fact]
        public void SwapNaturalNumbersWithoutTmpMaxIntTest()
        {
            var task = new TasksOfTheSemester();

            Assert.Throws<OverflowException>(() => task.SwapNaturalNumbersWithoutTmp(x: uint.MaxValue, y: 20));
        }
        #endregion

        #region Task 5
        [Fact]
        public void CountLeapYearsSimpleTest()
        {
            var task = new TasksOfTheSemester();

            var result = task.CountLeapYears(2019, 2021);

            Assert.Equal<int>(1, result);
        }
        #endregion

        #region Task 6
        [Fact]
        public void CalcPathFormPointToLineSimpleTest()
        {
            var task = new TasksOfTheSemester();

            var result = task.CalcPathFormPointToLine((2, 2), (4, 1), (1, 1));

            Assert.Equal<double>(1, result);
        }
        #endregion
    }
}

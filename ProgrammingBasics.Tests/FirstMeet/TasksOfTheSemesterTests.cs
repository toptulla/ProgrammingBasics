using ProgrammingBasics.Domain.FirstMeet;
using System;
using Xunit;

namespace ProgrammingBasics.Tests.FirstMeet
{
    public class TasksOfTheSemesterTests
    {
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
    }
}

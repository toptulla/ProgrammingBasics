using ProgrammingBasics.Domain.Errors;
using Xunit;

namespace ProgrammingBasics.Tests.Errors
{
    public class LectureTasksTests
    {
        [Theory]
        [InlineData(0, 3, 2, "Impossible")]
        [InlineData(0, 4, 5, "Impossible")]
        [InlineData(1, 2, 3, "-1")]
        [InlineData(1, -2, -3, "1")]
        [InlineData(5, 2, 1, "-0,2")]
        [InlineData(4, 3, 2, "-0,375")]
        [InlineData(0, 0, 2, "Any")]
        [InlineData(0, 0, 0, "Any")]
        public void FunctionMinimunSimpleTest(int a, int b, int c, string expected)
        {
            var functionMinimum = new LectureTasks();

            var actual = functionMinimum.GetMinX(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}

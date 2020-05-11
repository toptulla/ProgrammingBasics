using ProgrammingBasics.Domain.Arrays;
using Xunit;

namespace ProgrammingBasics.Tests.Arrays
{
    public class TasksForSeminarTests
    {
        [Fact]
        public void ShiftArraySimpleTest()  
        {
            var task = new TasksForSeminar();

            var shiftedArray = task.ShiftArray(new[] { 1, 2, 3, 4, 5 }, 2);

            Assert.Equal<int[]>(new[] { 4, 5, 1, 2, 3 }, shiftedArray);
        }

        [Fact]
        public void FromSystemToSystemSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.FromSystemToSystem(4, 4, new[] { 1, 1 });

            Assert.Equal<int[]>(new[] { 1, 1 }, result);
        }

        [Fact]
        public void GetUnionIntersectionDifferenceSimpleTest()
        {
            var task = new TasksForSeminar();

            var result = task.GetUnionIntersectionDifference(new[] { 1, 3, 4, 7, 9 }, new[] { 3, 4, 5, 8, 10 });

            Assert.Equal<int[]>(new[] { 1, 3, 4, 5, 7, 8, 9, 10 }, result.Union);
            Assert.Equal<int[]>(new[] { 3, 4 }, result.Intersection);
            Assert.Equal<int[]>(new[] { 1, 7, 9 }, result.Difference);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 3, 5, 7, 9 }, 2)]
        [InlineData(new[] { 1, 2, 5 }, 4)]
        [InlineData(new[] { 1, 3 }, 2)]
        [InlineData(new[] { 1, 2, 4, 6 }, 14)]
        [InlineData(new[] { 1, 2, 4, 8 }, 16)]
        [InlineData(new[] { 1, 2, 4 }, 8)]
        [InlineData(new[] { 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { }, 1)]
        public void GetSmallestNumberSimpleTest(int[] numbers, int smullestNumber)
        {
            var task = new TasksForSeminar();

            int result = task.GetSmallestNumber(numbers);

            Assert.Equal(smullestNumber, result);
        }
    }
}

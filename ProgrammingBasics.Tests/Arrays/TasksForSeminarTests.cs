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
    }
}

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
    }
}

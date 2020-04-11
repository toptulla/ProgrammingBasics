using ProgrammingBasics.Domain.Arrays;
using Xunit;

namespace ProgrammingBasics.Tests.Arrays
{
    public class LectureTasksTests
    {
        [Fact]
        public void GetIndexOfMaxElementSimpleTest()
        {
            var tasks = new LectureTasks();

            var index = tasks.GetIndexOfMaxElement(new double[] { 1, 2.2, 6, 2 });

            Assert.Equal(2, index);
        }

        [Fact]
        public void GetElementCountSimpleTest()
        {
            var tasks = new LectureTasks();

            var index = tasks.GetElementCount(new int[] { 1, 2, 6, 2, 4, 2, 1 }, 2);

            Assert.Equal(3, index);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 3, 4 }, new[] { 3, 4 }, 2)]
        [InlineData(new int[] { 1, 2, 3, }, new[] { 3, 4 }, -1)]
        public void FindSubarrayStartIndexSimpleTest(int[] array, int[] subArray, int expectedIndex)
        {
            var tasks = new LectureTasks();

            var index = tasks.FindSubarrayStartIndex(array, subArray);

            Assert.Equal(expectedIndex, index);
        }

        [Theory]
        [InlineData(Suits.Wands, "жезлов")]
        [InlineData(Suits.Coins, "монет")]
        [InlineData(Suits.Cups, "кубков")]
        [InlineData(Suits.Swords, "мечей")]
        public void GetSuitSimpleTest(Suits suit, string expectedTranslate)
        {
            var tasks = new LectureTasks();

            var index = tasks.GetSuit(suit);

            Assert.Equal(expectedTranslate, index);
        }

        public static Mark[,] CircleWin => new[,] { { Mark.Circle, Mark.Circle, Mark.Circle }, { Mark.Circle, Mark.Circle, Mark.Circle }, { Mark.Circle, Mark.Circle, Mark.Circle } };

        [Theory]
        [InlineData(
            new[] { Mark.Circle, Mark.Circle, Mark.Circle },
            new[] { Mark.Cross, Mark.Cross, Mark.Empty },
            new[] { Mark.Empty, Mark.Empty, Mark.Empty },
            GameResult.CircleWin)]
        [InlineData(
            new[] { Mark.Circle, Mark.Circle, Mark.Empty },
            new[] { Mark.Cross, Mark.Cross, Mark.Cross },
            new[] { Mark.Empty, Mark.Empty, Mark.Empty },
            GameResult.CrossWin)]
        [InlineData(
            new[] { Mark.Empty, Mark.Empty, Mark.Cross },
            new[] { Mark.Empty, Mark.Cross, Mark.Empty },
            new[] { Mark.Cross, Mark.Circle, Mark.Circle },
            GameResult.CrossWin)]
        [InlineData(
            new[] { Mark.Cross, Mark.Circle, Mark.Cross },
            new[] { Mark.Cross, Mark.Circle, Mark.Cross },
            new[] { Mark.Circle, Mark.Cross, Mark.Circle },
            GameResult.Draw)]
        [InlineData(
            new[] { Mark.Cross, Mark.Cross, Mark.Cross },
            new[] { Mark.Circle, Mark.Circle, Mark.Circle },
            new[] { Mark.Empty, Mark.Empty, Mark.Empty },
            GameResult.Draw)]
        public void GetGameResultSimpleTest(Mark[] firstLine, Mark[] secondLine, Mark[] thirdLine, GameResult expectedResult)
        {
            var tasks = new LectureTasks();

            var field = new Mark[,]
            {
                { firstLine[0], firstLine[1], firstLine[2] },
                { secondLine[0], secondLine[1], secondLine[2] },
                { thirdLine[0], thirdLine[1], thirdLine[2] }
            };
            var index = tasks.GetGameResult(field);

            Assert.Equal(expectedResult, index);
        }
    }
}

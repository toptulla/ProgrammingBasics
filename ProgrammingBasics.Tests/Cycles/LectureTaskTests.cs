using Xunit;
using ProgrammingBasics.Domain.Cycles;

namespace ProgrammingBasics.Tests.Cycles
{
    public class LectureTaskTests
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData(" b", "b")]
        [InlineData(" cd", "cd")]
        [InlineData(" efg", "efg")]
        [InlineData(" text", "text")]
        [InlineData(" two words", "two words")]
        [InlineData("  two spaces", "two spaces")]
        [InlineData("	tabs", "tabs")]
        [InlineData("		two	tabs", "two	tabs")]
        [InlineData("                             many spaces", "many spaces")]
        [InlineData("               ", "")]
        [InlineData("\n\r line breaks are spaces too", "line breaks are spaces too")]
        public void RemoveSpacesSimpleTests(string text, string expected)
        {
            var tasks = new LectureTasks();

            var actual = tasks.RemoveSpaces(text);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello world", "+-------------+", "| Hello world |", "+-------------+")]
        public void GetFramedTextSimpleTest(string text, string expectedFl, string expectedSl, string expectedTl)
        {
            var tasks = new LectureTasks();

            var actual = tasks.GetFramedText(text);

            Assert.Equal(expectedFl, actual.fl);
            Assert.Equal(expectedSl, actual.sl);
            Assert.Equal(expectedTl, actual.tl);
        }

        [Theory]
        [InlineData(1, new[] { "#" })]
        [InlineData(2, new[] { "#.", ".#" })]
        [InlineData(3, new[] { "#.#", ".#.", "#.#" })]
        public void GenerateChessBoardSimpleTest(int sideSize, string[] expectedChessBoardLines)
        {
            var tasks = new LectureTasks();

            var actualChessBoardLines = tasks.GenerateChessBoard(sideSize);

            Assert.Equal(expectedChessBoardLines, actualChessBoardLines);
        }
    }
}

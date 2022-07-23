

namespace Example2.Tests
{
    /// <summary>
    /// Общий контекст между тестами
    /// разобраться и поправить момент с dipose
    /// </summary>
    public class PointTests6 : IClassFixture<Point>
    {
        Point point;

        public PointTests6(Point point)
        {
            this.point = point;
        }

        /// <summary>
        /// https://github.com/asherber/Xunit.Priority
        /// решит проблемму но это не правильный модульный тест
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 6)]
        [InlineData(-6, 0)]
        public void MoveToX_MoveXBySteps(int steps, int expected)
        {
            point.MoveToX(steps);

            Assert.Equal(expected, point.X);
        }

        [Fact]
        public void MoveToX_MoveXBy101_ArgumentOutOfRangeException()
        {
            Action move = () => point.MoveToX(101);

            Assert.Throws<ArgumentOutOfRangeException>(move);
        }

    }
}
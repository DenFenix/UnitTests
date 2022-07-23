

namespace Example2.Tests
{
    /// <summary>
    /// Общий контекст между тестами
    /// разобраться и поправить момент с dipose
    /// конструктор и удаление
    /// </summary>
    public class PointTests5 :IDisposable
    {
        Point point;

        public PointTests5()
        {
            point = new Point();
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
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

        public void Dispose()
        {
        }
    }
}
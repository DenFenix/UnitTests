

namespace Example2.Tests
{
    /// <summary>
    /// Что тестов может быть несколько они тестируют один аспект за раз, но нужны какие то правила наименования
    /// </summary>
    public class PointTests1
    {
        [Fact]
        public void MoveToXTest()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.Equal(1, point.X);
        }

        [Fact]
        public void MoveToYTest()
        {
            Point point = new Point();

            point.MoveToY(1);

            Assert.Equal(1, point.Y);
        }
    }
}
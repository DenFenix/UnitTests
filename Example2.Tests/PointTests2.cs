
namespace Example2.Tests
{
    /// <summary>
    /// https://habr.com/ru/post/554808/
    /// [“естируемыйћетод]_[—ценарий]_[ќжидаемый–езультат]
    /// </summary>
    public class PointTests2
    {
        [Fact]
        public void MoveToX_MoveXBy1_Equal1()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.Equal(1, point.X);
        }

        [Fact]
        public void MoveToY_MoveYBy1_Equal1()
        {
            Point point = new Point();

            point.MoveToY(1);

            Assert.Equal(1, point.Y);
        }
    }
}
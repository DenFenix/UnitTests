using Examle1;

namespace Example1.Tests
{
    public class PointTests
    {
        [Fact]
        public void MoveToXTest()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.Equal(1, point.X);
        }
    }
}
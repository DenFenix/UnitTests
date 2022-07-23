using Examle1;

namespace NUnit_Example1.Tests
{
    public class PointTests
    {
        [Test]
        public void MoveToXTest()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.AreEqual(1, point.X);
        }
    }
}
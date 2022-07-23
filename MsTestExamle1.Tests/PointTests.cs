using Examle1;

namespace MsTestExamle1.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void MoveToXTest()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.AreEqual(1, point.X);
        }
    }
}
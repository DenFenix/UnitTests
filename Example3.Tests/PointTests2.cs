using Example3;
using Moq;

namespace Example3.Tests
{
    /// <summary>
    /// добавление Моков 
    /// привести в пример https://enterprisecraftsmanship.com/posts/when-to-mock/
    /// https://habr.com/ru/post/150859/
    /// </summary>
    public class PointTests2
    {
        private Point CreatePoint()
        {
            var point = new Point();
            var mock = new Mock<IDataBase>();
            point.DB = mock.Object;
            return point;
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
        public void MoveToX_MoveXBySteps(int steps, int expected)
        {
            var point = CreatePoint();

            point.MoveToX(steps);

            Assert.Equal(expected, point.X);
        }


        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
        public void MoveToXY_MoveXBySteps(int steps, int expected)
        {
            var point = new Point();
            var mock = new Mock<IDataBase>();
            mock.Setup(x => x.Save(steps, 0)).Returns(true);
            point.DB = mock.Object;

            var isSuccess = point.MoveToXY(steps , 0);

            Assert.Equal(expected, point.X);
            Assert.True(isSuccess);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        public void MockTest(int steps)
        {
            var db = Mock.Of<IDataBase>(x => x.Save(steps, 0) == true);
            var t = db.Save(steps, 0); //работает
            var t2 = db.Save(steps, 1); // не работает
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        public void MockTest2(int steps)
        {
            var db = Mock.Of<IDataBase>(x => x.Save(It.IsAny<int>(), It.IsAny<int>()) == true);
            var t = db.Save(steps, 0); //работает
            var t2 = db.Save(steps, 1); // не работает
        }
    }
}
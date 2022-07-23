using Example3;

namespace Example3.Tests
{
    //используем рукописную заглушку
    //лучше использовать фабричный метод
    public class PointTests1
    {
        //Point point;
        public PointTests1()
        {
            //point = new Point();
            //point.DB = new DataBaseMock();
        }
        //-> фабричный метод
        private Point CreatePoint()
        {
            var point = new Point();
            point.DB = new DataBaseMock();
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
    }
}
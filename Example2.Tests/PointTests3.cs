

namespace Example2.Tests
{
    /// <summary>
    /// работа с несколькими тестами
    /// Понимаем что можно целую простыню кода так наваять
    /// </summary>
    public class PointTests3
    {
        [Fact]
        public void MoveToX_MoveXBy1_Equal1()
        {
            Point point = new Point();

            point.MoveToX(1);

            Assert.Equal(1, point.X);
        }

        [Fact]
        public void MoveToX_MoveXBy2_Equal2()
        {
            Point point = new Point();

            point.MoveToX(-1);

            Assert.Equal(-1, point.X);
        }

        [Fact]
        public void MoveToX_MoveXBy0_Equal0()
        {
            Point point = new Point();

            point.MoveToX(0);

            Assert.Equal(0, point.X);
        }

        //В случае если хочется написать тест без утверждения
        [Fact]
        public void MoveToX_MoveXBy0_Equal1()
        {
            Point point = new Point();

            point.MoveToX(0);

            Exception ex = Record.Exception(() => () => point.MoveToX(1));

            Assert.Null(ex);
        }

    }
}
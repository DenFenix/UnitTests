

namespace Example2.Tests
{
    /// <summary>
    /// ��������� � ������������
    /// https://habr.com/ru/post/357648/
    /// https://xunit.net
    /// </summary>
    public class PointTests4
    {
        /// <summary>
        /// ������ ����� �� ������� ���� ���������� ������ �� ����� ����� �������� 
        /// ����������� �������� ��� ������ ������ � ��� �� ������� � ����������.
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(1,1)]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
        public void MoveToX_MoveXBySteps(int steps, int expected)
        {
            Point point = new Point();

            point.MoveToX(steps);

            Assert.Equal(expected, point.X);
        }

        /// <summary>
        /// ��������� ������
        /// </summary>
        [Fact]
        public void MoveToX_MoveXBy101_ArgumentOutOfRangeException()
        {
            Point point = new Point();

            Action move = () => point.MoveToX(101);

            Assert.Throws<ArgumentOutOfRangeException>(move);
        }
    }
}
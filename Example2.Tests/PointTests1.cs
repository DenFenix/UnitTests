

namespace Example2.Tests
{
    /// <summary>
    /// Что тестов может быть несколько они тестируют один аспект за раз, но нужны какие то правила наименования
    /// </summary>
    public class PointTests1
    {
        /*
            Equal	Verifies that two values are equal. There are various overloads that accepts int, string, DateTime, and other types of values.
            Null	Verifies that an object is null.
            True	Verifies that a condition is true.
            False	Verifies that a condition is false.
            IsType	Verifies that an object is of a given type.
            IsAssignableFrom	Verifies that an object is of the given type or a derived type.
        */

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
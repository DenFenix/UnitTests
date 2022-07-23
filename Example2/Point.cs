namespace Example2
{
    public class Point
    {
        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 0;

        public void MoveToX(int steps)
        {
            if (steps > 100)
                throw new ArgumentOutOfRangeException();
            X = X + steps;
        }
        public void MoveToY(int steps)
        {
            Y = Y + steps;
        }
    }
}
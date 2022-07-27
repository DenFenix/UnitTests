namespace Example3.Incorrect
{//пример в котором нужно разоврвать зависимости
    public class Point
    {
        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 0;

        public void MoveToX(int steps)
        {
            X = X + steps;
            var db = new DataBase();
            db.SaveX(X);
        }
        public void MoveToY(int steps)
        {
            Y = Y + steps;
            var db = new DataBase();
            db.SaveX(Y);
        }
    }
}
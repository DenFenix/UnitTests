namespace Example3
{//пример в котором нужно разоврвать зависимости
    public class Point
    {
        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 0;
        public IDataBase DB{get;set;}

        public void MoveToX(int steps)
        {
            X = X + steps;
            DB.SaveX(X);
        }
        public void MoveToY(int steps)
        {
            Y = Y + steps;
            DB.SaveX(Y);
        }

        public bool MoveToXY(int stepsX, int stepsY)
        {
            X = X + stepsX;
            Y = Y + stepsY;
            return DB.Save(X, Y);
        }
    }
}
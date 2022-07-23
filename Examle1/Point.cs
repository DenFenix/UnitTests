using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examle1
{
    /// <summary>
    /// https://xunit.net/docs/comparisons
    /// сравнение Xunit с другими фрэймворками
    /// </summary>
    public class Point
    {
        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 0;

        public void MoveToX(int steps)
        {
            X = X + steps;
        }
        public void MoveToY(int steps)
        {
            Y = Y + steps;
        }
    }
}

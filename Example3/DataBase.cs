using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class DataBase : IDataBase
    {
        private static int _x;
        private static int _y;

        public bool Save(int x, int y)
        {
            _x = x;
            _y = y;
            return true;
        }

        public void SaveX(int x) 
        {
            _x = x;
        }
        public void SaveY(int y) 
        {
            _y = y;
        }
    }
}

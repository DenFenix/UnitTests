using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Tests
{
    internal class DataBaseMock : IDataBase
    {
        public bool Save(int x, int y)
        {
            return true;
        }

        public void SaveX(int x)
        {
        }

        public void SaveY(int y)
        {
        }
    }
}

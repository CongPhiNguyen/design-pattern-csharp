using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeIterator
{
    public class DataType
    {
        int val = 0;
        public DataType(int val)
        {
            this.val = val;
        }
        public int Value { get { return val; } }
    }
}

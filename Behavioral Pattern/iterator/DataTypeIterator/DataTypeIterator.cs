using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeIterator
{
    public class DataTypeIterator
    {
        DataTypeAggregate aggregate;
        int current = 0;

        public DataTypeIterator(DataTypeAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public DataType Begin()
        {
            return aggregate.Value[0];
        }

        public DataType Next()
        {
            DataType next = null;
            if (current < aggregate.Length() - 1)
            {
                next = aggregate.Value[current + 1];
            }
            current++;
            return next;
        }

        public int Value()
        {
            if (current >= aggregate.Length()) return 0;
            else 
                return aggregate.Value[current].Value;
        }

        public bool isEnd()
        {
            return current >= aggregate.Length();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeIterator
{
    public class DataTypeAggregate
    {
        List<DataType> items;
        public List<DataType> Value {get { return items; }}

        public DataTypeAggregate()
        {
            items = new List<DataType>();
        }

        public DataTypeIterator CreateIterator()
        {
            return new DataTypeIterator(this);
        }
        public int Length()
        {
            return items.Count;
        }

        public DataType this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}

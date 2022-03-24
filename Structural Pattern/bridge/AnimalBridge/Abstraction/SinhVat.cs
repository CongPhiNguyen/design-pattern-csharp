using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBridge
{
    internal class SinhVat
    {
        protected AnThucAn implementor;
        public AnThucAn Implementor
        {
            set { implementor = value; }
        }
        public virtual void Operation()
        {
            implementor.operation();
        }
    }
}

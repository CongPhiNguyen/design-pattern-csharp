using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Factory2 : AbstractFactory
    {
        public override AbstractProductA createProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB createProductB()
        {
            return new ProductB2();
        }
    }
}

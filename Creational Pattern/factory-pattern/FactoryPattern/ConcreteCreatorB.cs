using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ConcreteCreatorB: CreatorFactory
    {
        public override ProductFactory FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}

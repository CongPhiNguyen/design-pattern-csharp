using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client
    {
        AbstractProductA abstractProductA;
        AbstractProductB abstractProductB;

        // Constructor

        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.createProductA();
            abstractProductB = factory.createProductB();
        }

        public void Run()
        {
            abstractProductB.interact(abstractProductA);
        }
    }
}

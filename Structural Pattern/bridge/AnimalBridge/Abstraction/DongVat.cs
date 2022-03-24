using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBridge
{
    internal class DongVat:SinhVat
    {
        public override void Operation()
        {
            Console.Write("Dong vat");
            implementor.operation();
        }
    }
}

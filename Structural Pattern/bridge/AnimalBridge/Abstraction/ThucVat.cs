using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalBridge
{
    internal class ThucVat : SinhVat
    {
        public override void Operation()
        {
            Console.Write("Thuc vat");
            implementor.operation();
        }
    }
}

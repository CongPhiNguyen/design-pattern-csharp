using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Facade
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Subsystem3 subsystem3 = new Subsystem3();   
        Subsystem4 subsystem4 = new Subsystem4();

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();  
            subsystem3 = new Subsystem3();
            subsystem4 = new Subsystem4();
        }

        public void MethodA()
        {
            Console.WriteLine("Method A() ---");
            subsystem1.method1();
            subsystem4.method4();
        }

        public void MethodB()
        {
            Console.WriteLine("Method B() ---");
            subsystem4.method4();
            subsystem3.method3();
            subsystem2.method2();
        }
    }
}

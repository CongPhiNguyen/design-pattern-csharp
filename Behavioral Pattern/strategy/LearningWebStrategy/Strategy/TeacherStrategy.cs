using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWebStrategy
{
    internal class TeacherStrategy : Strategy
    {
        public override void webAcessing()
        {
            Console.WriteLine("Get student list....");
            Console.WriteLine("Get student score....");
            Console.WriteLine("Get class list....");
        }
    }
}

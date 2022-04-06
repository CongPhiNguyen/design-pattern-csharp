using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWebStrategy
{
    internal class StudentStrategy : Strategy 
    {
        public override void webAcessing()
        {
            Console.WriteLine("Get courses....");
            Console.WriteLine("Get deadline schedule....");
            Console.WriteLine("Get document....");
        }
    }
}

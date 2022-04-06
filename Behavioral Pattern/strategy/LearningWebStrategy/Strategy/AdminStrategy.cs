using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWebStrategy
{
    internal class AdminStrategy : Strategy 
    {
        public override void webAcessing()
        {
            Console.WriteLine("Get Accessing tracking list...");
            Console.WriteLine("Get Data tracking list...");
            Console.WriteLine("Get issue report list...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public class OSExpression : IExpression
    {
        public void InterpreterContext(Context context)
        {
            if (context.getIsProgram() == true)
            {
                Console.WriteLine("OS name is: {0}", context.getOS());
            }
            else
            {
                Console.WriteLine("OS name could not be interpreter");
            }
        }
    }
}

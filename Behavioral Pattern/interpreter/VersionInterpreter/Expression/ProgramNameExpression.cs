using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public class ProgramNameExpression : IExpression
    {
        public void InterpreterContext(Context context)
        {
            if (context.getIsProgram() == true)
            {
                Console.WriteLine("Program name is: {0}", context.getProgramName());
            }
            else
            {
                Console.WriteLine("Program name could not be interpreter");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public class CheckExpression : IExpression
    {
        public void InterpreterContext(Context context)
        {
            if (context.getVersion() != "" && context.getProgramName() != "" && context.getOS() != "")
            {
                context.setIsProgram(true);
                Console.WriteLine("{0} is a version string", context.getVersionString());
            }
            else
            {
                context.setIsProgram(false);
                Console.WriteLine("{0} is a version string", context.getVersionString());
            }
        }
    }
}

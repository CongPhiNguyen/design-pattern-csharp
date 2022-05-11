using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public class VersionExpression : IExpression
    {
        public void InterpreterContext(Context context)
        {
            if(context.getIsProgram() == true)
            {
                Console.WriteLine("Version is: {0}", context.getVersion());
            }
            else
            {
                Console.WriteLine("Version could not be interpreter");
            }
        }
    }
}

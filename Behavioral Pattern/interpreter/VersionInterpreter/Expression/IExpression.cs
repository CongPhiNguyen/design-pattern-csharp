using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public interface IExpression
    {
        void InterpreterContext(Context context);
    }
}

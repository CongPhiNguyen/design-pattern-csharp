using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "This is specific request";
        }
    }
}

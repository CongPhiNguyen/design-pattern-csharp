using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChain
{
    public class Request
    {
        public string type;
        public string value;

        public Request(string type = "", string value = "")
        {
            this.type = type;
            this.value = value;
        }
    }
}
